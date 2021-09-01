using CostNAG.Models;
using CostNAGAPI.Models;
using CostNAGAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAGAPI.Services
{
    public class CostService
    {
        private CostDbContext _context;
        public CostService(CostDbContext context)
        {
            _context = context;
        }

        public void AddCost(CostVM cost)
        {
            var _cost = new Cost()
            {
                plant = cost.plant,
                item_spec = cost.item_spec,
                issue_date = cost.issue_date,
                section = cost.section
            };

            _context.Costs.Add(_cost);
            _context.SaveChanges();

        }


        //public List<Cost> GetAllCost()
        //{
        //    return _context.Costs.ToList();
        //}
        public List<Cost> GetAllCost() => _context.Costs.ToList();
        public Cost GetCostById(int costId) => _context.Costs.FirstOrDefault(n => n.CostId == costId);

        public Cost UpdateCostById(int costId, CostVM cost)
        {
            var _cost = _context.Costs.FirstOrDefault(n => n.CostId == costId);
            //if we found the cost data then we will update the data
            if (_cost != null)
            {
                _cost.plant = cost.plant;
                _cost.item_spec = cost.item_spec;
                _cost.issue_date = cost.issue_date;
                _cost.section = cost.section;

                _context.SaveChanges();
            }
            return _cost;
        }

    }
}











