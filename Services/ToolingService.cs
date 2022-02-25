using CostNAG.Models;
using CostNAGAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CostNAGAPI.Services
{
    public class ToolingService
    {

        private CostDbContext _context;
        public ToolingService(CostDbContext context)
        {
            _context = context;
        }

        public List<Tooling> GetAllTooling() =>
            _context.Toolings.OrderBy(n => n.description).ToList();


        public void AddToolingData(Tooling r)
        {
            var _tooling = new Tooling()
            {
                description = r.description,
                source = r.source,
                qty = r.qty,
                unit = r.unit,
                price = r.price,
                od = r.od
            };

            _context.Toolings.Add(_tooling);
            _context.SaveChanges();

        }


        public List<Tooling> GetToolingByOd(int Od) =>
            _context.Toolings.Where(n => n.od == Od || n.od == 0).ToList();

        public Tooling GetToolingById(int Id) =>
            _context.Toolings.FirstOrDefault(n => n.ToolingId == Id);


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
