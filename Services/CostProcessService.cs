using CostNAG.Models;
using CostNAGAPI.Models;
using CostNAGAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAGAPI.Services
{
    public class CostProcessService
    {
        private CostDbContext _context;
        public CostProcessService(CostDbContext context)
        {
            _context = context;
        }


        public List<CostProcess> GetAllCostProcess() => _context.CostsProcesses.ToList();

        public CostProcess GetCostProcessById(int costProcessId) => 
            _context.CostsProcesses.FirstOrDefault(n => n.CostProcessId == costProcessId);

        public List<CostProcess> GetCostProcessByDocNo(string doc_no)
        {
            var _data = _context.CostsProcesses
                .Where(n => n.doc_no == doc_no)
                .OrderBy(d => d.process_type)
                .ThenBy(d2 => d2.process_name)
                .ToList();

            return _data;

        }

        public void AddCostProcess(CostProcessVM p)
        {
            var _process = new CostProcess()
            {
                doc_no = p.doc_no,
                process_name = p.process_name,
                process_type = p.process_type,
                item_od = p.item_od,
                overhead_cost = p.overhead_cost,
                machine_cost = p.machine_cost,
                labor_cost = p.labor_cost,
                total_cost = p.total_cost

            };
            _context.CostsProcesses.Add(_process);
            _context.SaveChanges();
        }


        public void DeleteCostProcessById(int Id)
        {
            var _data = _context.CostsProcesses.FirstOrDefault(n => n.CostProcessId == Id);
            if (_data != null)
            {
                _context.CostsProcesses.Remove(_data);
                _context.SaveChanges();
            }

        }


    }
}
