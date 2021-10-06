using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CostNAG.Models;
using CostNAGAPI.Models;
using CostNAGAPI.ViewModels;

namespace CostNAGAPI.Services
{
    public class ProcessService
    {
        private CostDbContext _context;
        public ProcessService(CostDbContext context)
        {
            _context = context;
        }

        public void AddProcess(ProcessVM p)
        {
            var _process = new Process()
            {
                doc_no = p.doc_no,
                process_name = p.process_name,
                working_day = p.working_day,
                working_time_day = p.working_time_day,
                working_time_month = p.working_time_month,
                shift = p.shift,
                worker = p.worker,
                direct_labour = p.direct_labour,
                total_labour_cost = p.total_labour_cost,
                machine_qty = p.machine_qty,
                area = p.area,
                special_material = p.special_material,
                plant_maintenance = p.plant_maintenance,
                plant_maintenance_unit = p.plant_maintenance_unit,
                total_machine_cost = p.total_machine_cost,
                machine_usage_day = p.machine_usage_day,
                machine_cost_month = p.machine_cost_month,
                machine_cost_month_percentage = p.machine_cost_month,
                machine_cost_month_percentage_unit = p.machine_cost_month_percentage_unit,
                consumption_kwh = p.consumption_kwh,
                consumption_unit = p.consumption_unit,
                consumption_sgd = p.consumption_sgd,
                consumption_rate = p.consumption_rate,
                utility_electric = p.utility_electric,
                machine_utility_cost = p.machine_utility_cost,
                labour_electric_cost = p.labour_electric_cost,
                charge = p.charge,
                cycle_time = p.cycle_time,
                cycle_time_unit = p.cycle_time_unit,
                time = p.time,
                capacity = p.capacity,
                time_g = p.time_g,
                efficiency = p.efficiency,
                production_capacity = p.production_capacity,
                production_cycle_time = p.production_cycle_time,
                special_input = p.special_input,
                direct_process_cost = p.direct_process_cost,
                labour_cost_percentage = p.labour_cost_percentage,
                machine_cost_percentage = p.machine_cost_percentage,
                overhead_cost_percentage = p.overhead_cost_percentage,
                total_cost_percentage = p.total_cost_percentage

            };

            _context.Processes.Add(_process);
            _context.SaveChanges();


        }

        public Process GetProcessById(int processId) => _context.Processes.FirstOrDefault(n => n.ProcessId == processId);

        public List<Process> GetProcessByDocNo(string doc_no)
        {
            var _process = _context.Processes
                .Where(n => n.doc_no == doc_no).ToList();

            return _process;

        }
        /*
        public ProcessVM GetProcessById(string doc_no)
        {
            var _process = _context.Processes
                .Where(n => n.doc_no == doc_no)
                .Select(p => new ProcessVM()
                {
                    doc_no = p.doc_no,
                    process_name = p.process_name,
                    working_day = p.working_day,
                    working_time_day = p.working_time_day,
                    working_time_month = p.working_time_month,
                    shift = p.shift,
                    worker = p.worker,
                    direct_labour = p.direct_labour,
                    total_labour_cost = p.total_labour_cost,
                    machine_qty = p.machine_qty,
                    area = p.area,
                    special_material = p.special_material,
                    plant_maintenance = p.plant_maintenance,
                    plant_maintenance_unit = p.plant_maintenance_unit,
                    total_machine_cost = p.total_machine_cost,
                    machine_usage_day = p.machine_usage_day,
                    machine_cost_month = p.machine_cost_month,
                    machine_cost_month_percentage = p.machine_cost_month,
                    machine_cost_month_percentage_unit = p.machine_cost_month_percentage_unit,
                    consumption_kwh = p.consumption_kwh,
                    consumption_unit = p.consumption_unit,
                    consumption_sgd = p.consumption_sgd,
                    consumption_rate = p.consumption_rate,
                    utility_electric = p.utility_electric,
                    machine_utility_cost = p.machine_utility_cost,
                    labour_electric_cost = p.labour_electric_cost,
                    charge = p.charge,
                    cycle_time = p.cycle_time,
                    cycle_time_unit = p.cycle_time_unit,
                    time = p.time,
                    capacity = p.capacity,
                    time_g = p.time_g,
                    efficiency = p.efficiency,
                    production_capacity = p.production_capacity,
                    production_cycle_time = p.production_cycle_time,
                    special_input = p.special_input,
                    direct_process_cost = p.direct_process_cost,
                    labour_cost_percentage = p.labour_cost_percentage,
                    machine_cost_percentage = p.machine_cost_percentage,
                    overhead_cost_percentage = p.overhead_cost_percentage,
                    total_cost_percentage = p.total_cost_percentage


    }).FirstOrDefault();

            return _process;
        }
        */



        public Process UpdateProcessById(int processId, Process process)
        {
            var _process = _context.Processes.FirstOrDefault(n => n.ProcessId == processId);
            //if we found the cost data then we will update the data
            if (_process != null)
            {
                _process.doc_no = process.doc_no;
                _process.process_name = process.process_name;
                _process.working_day = process.working_day;
                _process.working_time_day = process.working_time_day;
                _process.working_time_month = process.working_time_month;
                _process.shift = process.shift;
                _process.worker = process.worker;
                _process.direct_labour = process.direct_labour;
                _process.total_labour_cost = process.total_labour_cost;
                _process.machine_qty = process.machine_qty;
                _process.area = process.area;
                _process.special_material = process.special_material;
                _process.plant_maintenance = process.plant_maintenance;
                _process.plant_maintenance_unit = process.plant_maintenance_unit;
                _process.total_machine_cost = process.total_machine_cost;
                _process.machine_usage_day = process.machine_usage_day;
                _process.machine_cost_month = process.machine_cost_month;
                _process.machine_cost_month_percentage = process.machine_cost_month;
                _process.machine_cost_month_percentage_unit = process.machine_cost_month_percentage_unit;
                _process.consumption_kwh = process.consumption_kwh;
                _process.consumption_unit = process.consumption_unit;
                _process.consumption_sgd = process.consumption_sgd;
                _process.consumption_rate = process.consumption_rate;
                _process.utility_electric = process.utility_electric;
                _process.machine_utility_cost = process.machine_utility_cost;
                _process.labour_electric_cost = process.labour_electric_cost;
                _process.charge = process.charge;
                _process.cycle_time = process.cycle_time;
                _process.cycle_time_unit = process.cycle_time_unit;
                _process.time = process.time;
                _process.capacity = process.capacity;
                _process.time_g = process.time_g;
                _process.efficiency = process.efficiency;
                _process.production_capacity = process.production_capacity;
                _process.production_cycle_time = process.production_cycle_time;
                _process.special_input = process.special_input;
                _process.direct_process_cost = process.direct_process_cost;
                _process.labour_cost_percentage = process.labour_cost_percentage;
                _process.machine_cost_percentage = process.machine_cost_percentage;
                _process.overhead_cost_percentage = process.overhead_cost_percentage;
                _process.total_cost_percentage = process.total_cost_percentage;


                _context.SaveChanges();
            }
            return _process;
        }

        public void DeleteProcessById(int processId)
        {
            var _process = _context.Processes.FirstOrDefault(n => n.ProcessId == processId);
            if (_process != null)
            {
                _context.Processes.Remove(_process);
                _context.SaveChanges();
            }

        }


    }
}
