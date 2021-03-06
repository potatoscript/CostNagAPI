using CostNAG.Models;
using CostNAGAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAGAPI.Services
{
    public class RubberService
    {

        private CostDbContext _context;
        public RubberService(CostDbContext context)
        {
            _context = context;
        }

        public void AddRubberData(Rubber r)
        {
            var _rubber = new Rubber()
            {
                material_name = r.material_name,
                price_kg = r.price_kg,
                mixing_process_cost = r.mixing_process_cost,
                weight_g = r.weight_g,
                yield_rate = r.yield_rate
            };

            _context.Rubbers.Add(_rubber);
            _context.SaveChanges();

        }

        public List<Rubber> GetAllRubber() => 
            _context.Rubbers.OrderBy(n => n.material_name).ToList();

        public Rubber GetRubberById(int Id) =>
            _context.Rubbers.FirstOrDefault(n => n.RubberId == Id);

        public Rubber GetRubberByName(string name) => 
            _context.Rubbers.FirstOrDefault(n => n.material_name == name);


        public Rubber UpdateRubberById(int Id, Rubber rubber)
        {
            var _rubber = _context.Rubbers.FirstOrDefault(n => n.RubberId == Id);
            if (_rubber != null)
            {
                _rubber.material_name = rubber.material_name;
                _rubber.price_kg = rubber.price_kg;
                _rubber.mixing_process_cost = rubber.mixing_process_cost;
                _rubber.weight_g = rubber.weight_g;
                _rubber.yield_rate = rubber.yield_rate;

                _context.SaveChanges();
            }
            return _rubber;
        }


        public void DeleteRubberById(int Id)
        {
            var _data = _context.Rubbers.FirstOrDefault(n => n.RubberId == Id);
            if (_data != null)
            {
                _context.Rubbers.Remove(_data);
                _context.SaveChanges();
            }

        }


    }
}
