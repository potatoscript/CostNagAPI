using CostNAG.Models;
using CostNAGAPI.Models;
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

        public void AddCost(Cost cost)
        {
            var _cost = new Cost()
            {
                plant = cost.plant,
                item_spec = cost.item_spec,
                issue_date = cost.issue_date,
                section = cost.section,
                doc_no =cost.doc_no,
                wr_no = cost.wr_no,
                sales = cost.sales,
                revision_no =cost.revision_no,
                checked_date = cost.checked_date,
                approved_by = cost.approved_by,
                customer = cost.customer,
                parts_code = cost.parts_code,
                item = cost.item,
                product = cost.product,
                product_type = cost.product_type,
                size = cost.size,
                business_type = cost.business_type,
                qty_month = cost.qty_month,
                exchange_rate = cost.exchange_rate,
                target_price_bht = cost.target_price_bht,
                target_price_export = cost.target_price_export,
                production_qty_day = cost.production_qty_day,
                working_day = cost.working_day
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

        public Cost UpdateCostById(int costId, Cost cost)
        {
            var _cost = _context.Costs.FirstOrDefault(n => n.CostId == costId);
            //if we found the cost data then we will update the data
            if (_cost != null)
            {
                _cost.plant = cost.plant;
                _cost.item_spec = cost.item_spec;
                _cost.issue_date = cost.issue_date;
                _cost.section = cost.section;
                _cost.doc_no = cost.doc_no;
                _cost.wr_no = cost.wr_no;
                _cost.sales = cost.sales;
                _cost.revision_no = cost.revision_no;
                _cost.checked_date = cost.checked_date;
                _cost.approved_by = cost.approved_by;
                _cost.customer = cost.customer;
                _cost.parts_code = cost.parts_code;
                _cost.item = cost.item;
                _cost.product = cost.product;
                _cost.product_type = cost.product_type;
                _cost.size = cost.size;
                _cost.business_type = cost.business_type;
                _cost.qty_month = cost.qty_month;
                _cost.exchange_rate = cost.exchange_rate;
                _cost.target_price_bht = cost.target_price_bht;
                _cost.target_price_export = cost.target_price_export;
                _cost.production_qty_day = cost.production_qty_day;
                _cost.working_day = cost.working_day;

                _context.SaveChanges();
            }
            return _cost;
        }

        public void DeleteCostById(int costId)
        {
            var _cost = _context.Costs.FirstOrDefault(n => n.CostId == costId);
            //if we found the cost data then we will update the data
            if (_cost != null)
            {
                _context.Costs.Remove(_cost);
                _context.SaveChanges();
            }

        }

    }
}











