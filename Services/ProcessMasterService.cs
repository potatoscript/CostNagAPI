using CostNAG.Models;
using CostNAGAPI.Models;
using CostNAGAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAGAPI.Services
{
    public class ProcessMasterService
    {

        private CostDbContext _context;
        public ProcessMasterService(CostDbContext context)
        {
            _context = context;
        }

        
        public List<ProcessMaster> GetAllProcessesMaster() => _context.ProcessesMaster.ToList();

        public ProcessMaster GetProcessMasterById(int processMasterId) => _context.ProcessesMaster.FirstOrDefault(n => n.ProcessMasterId == processMasterId);

        public List<ProcessMaster> GetProcessMasterByOD(double od)
        {
            var _data = _context.ProcessesMaster
                .Where(n => n.od_min <= od && n.od_max >= od).ToList();

            return _data;

        }

        public List<ProcessMasterVM> GetProcessNameByOD(double od)
        {
            var _data = _context.ProcessesMaster
                .Where(n => n.od_min <= od && n.od_max >= od)
                .Select(d => new { d.process_name, d.process_type })
                .Distinct()
                .OrderBy(d => d.process_name)
                .ToList();

            List<ProcessMasterVM> list = new List<ProcessMasterVM>();
            foreach (var i in _data)
            {
                
                list.Add(new ProcessMasterVM { 
                    process_name = i.process_name,
                    process_type = i.process_type
                });
            }

            return list;

        }

        public void AddProcessMaster(ProcessMasterVM p)
        {
            var _process = new ProcessMaster()
            {
                process_name = p.process_name,
                od_min = p.od_min,
                od_max = p.od_max,
                overhead_cost = p.overhead_cost,
                machine_cost = p.machine_cost,
                labor_cost = p.labor_cost,
                total_cost = p.total_cost

            };
            _context.ProcessesMaster.Add(_process);
            _context.SaveChanges();
        }

        public ProcessMaster UpdateProcessMasterById(int Id, ProcessMasterVM data)
        {
            var _data = _context.ProcessesMaster.FirstOrDefault(n => n.ProcessMasterId == Id);
            if (_data != null)
            {
                _data.process_name = data.process_name;
                _data.od_min = data.od_min;
                _data.od_max = data.od_max;
                _data.overhead_cost = data.overhead_cost;
                _data.machine_cost = data.machine_cost;
                _data.labor_cost = data.labor_cost;
                _data.total_cost = data.total_cost;

                _context.SaveChanges();
            }
            return _data;
        }

        public void DeleteProcessMasterById(int Id)
        {
            var _data = _context.ProcessesMaster.FirstOrDefault(n => n.ProcessMasterId == Id);
            if (_data != null)
            {
                _context.ProcessesMaster.Remove(_data);
                _context.SaveChanges();
            }

        }







    }
}
