using CostNAG.Models;
using CostNAGAPI.Models;
using CostNAGAPI.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CostNAGAPI.Services
{
    public class ToolingService
    {

        public IConfiguration _server;

        private CostDbContext _context;
        public ToolingService(CostDbContext context, IConfiguration configuration)
        {
            _context = context;
            _server = configuration;
        }

        public List<Tooling> GetAllTooling() =>
            _context.Toolings
            .OrderBy(n => n.description)
            //.OrderByDescending(n => n.description)
            //.Take(100)
            .ToList();


        public void AddToolingData(Tooling r)
        {
            var _tooling = new Tooling()
            {
                description = r.description,
                source = r.source,
                qty = r.qty,
                unit = r.unit,
                price = r.price,
                od = r.od,
                od_max = r.od_max,
                type = r.type
            };

            _context.Toolings.Add(_tooling);
            _context.SaveChanges();

        }


        public List<ToolingsVM> GetToolingByPage(int currentPage)
        {
            int maxRows = 10;
            //Tooling toolingModel = new Tooling();

            ToolingsVM list = new ToolingsVM();
            var n = 0;

            string sql0 = "SELECT max(\"ToolingId\") FROM \"Toolings\"  ";
            Database db0 = new Database(sql0, _server);
            if (db0.data.HasRows)
            {
                while (db0.data.Read())
                {
                    n = Int32.Parse(db0.data[0].ToString());
                }
            }
            db0.Close();

            double pageCount = (double)(n / Convert.ToDecimal(maxRows));

            int MinID = (int)currentPage * maxRows - maxRows;
            int MaxID = (int)currentPage * maxRows;

            if (MinID < 0) MinID = 0;

            string sql = "SELECT "+
                " \"ToolingId\", "+
                " description, source, qty, unit, price, od, od_max,type "+
                " FROM \"Toolings\" ";
            sql += " WHERE \"ToolingId\" > '" + MinID + "' AND ";

            sql += " \"ToolingId\" <= '" + MaxID + "'  ";
            sql += " ORDER BY description ";

            Database db = new Database(sql, _server);
            if (db.data.HasRows)
            {
                while (db.data.Read())
                {
                    list.ListModel.Add(new ToolingsVM
                    {
                        ToolingId = Int32.Parse(db.data[0].ToString()),
                        description = db.data[1].ToString(),
                        source = db.data[2].ToString(),
                        qty = double.Parse(db.data[3].ToString()),
                        unit = db.data[4].ToString(),
                        price = double.Parse(db.data[5].ToString()),
                        od = double.Parse(db.data[6].ToString()),
                        od_max = double.Parse(db.data[7].ToString()),
                        type = db.data[8].ToString(),
                        PageCount = (int)Math.Ceiling(pageCount),
                        CurrentPageIndex = currentPage
                    });

                }

            }
            db.Close();


            List<ToolingsVM> model = list.ListModel.ToList();


            //return costModel;
            return model;
        }

        public List<Tooling> GetToolingByOdType(int Od, string type) =>
            _context.Toolings
            .Where(n => ((n.type == type || n.type == "-" ) && n.od <= Od && n.od_max >= Od ) || 
            n.od_max == 0)
            .OrderBy(n => n.description)
            .ToList();

        public Tooling GetToolingById(int Id) =>
            _context.Toolings.FirstOrDefault(n => n.ToolingId == Id);

        public List<ToolingsVM> GetToolingBySearch(string description)
        {
            ToolingsVM list = new ToolingsVM();

            string sql = "SELECT \"ToolingId\",description,source,qty,unit,price,od,od_max,type FROM \"Toolings\" ";
            sql += " WHERE description LIKE '%" + description + "%' ";
            sql += " ORDER BY description ";

            Database db = new Database(sql, _server);
            if (db.data.HasRows)
            {
                while (db.data.Read())
                {
                    list.ListModel.Add(new ToolingsVM
                    {
                        ToolingId = Int32.Parse(db.data[0].ToString()),
                        description = db.data[1].ToString(),
                        source = db.data[2].ToString(),
                        qty = double.Parse(db.data[3].ToString()),
                        unit = db.data[4].ToString(),
                        price = double.Parse(db.data[5].ToString()),
                        od = double.Parse(db.data[6].ToString()),
                        od_max = double.Parse(db.data[7].ToString()),
                        type = db.data[8].ToString()
                    });
                }
            }
            db.Close();

            List<ToolingsVM> model = list.ListModel.ToList();

            return model;
        }

        public Tooling UpdateToolingById(int Id, Tooling tooling)
        {
            var _tooling = _context.Toolings.FirstOrDefault(n => n.ToolingId == Id);
            if (_tooling != null)
            {
                _tooling.description = tooling.description;
                _tooling.source = tooling.source;
                _tooling.qty = tooling.qty;
                _tooling.unit = tooling.unit;
                _tooling.price = tooling.price;
                _tooling.od = tooling.od;
                _tooling.od_max = tooling.od_max;
                _tooling.type = tooling.type;

                _context.SaveChanges();
            }
            return _tooling;
        }


        public void DeleteToolingById(int Id)
        {
            var _data = _context.Toolings.FirstOrDefault(n => n.ToolingId == Id);
            if (_data != null)
            {
                _context.Toolings.Remove(_data);
                _context.SaveChanges();
            }

        }


    }
}
