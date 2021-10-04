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

        public ProcessVM GetProcessById(string doc_no)
        {
            var _costWithProcess = _context.Processes
                .Where(n => n.doc_no == doc_no)
                .Select(process => new ProcessVM()
                {
                    process_name = process.process_name,
                    remark = process.remark,
                    working_days = process.working_days,
                    working_time_daily = process.working_time_daily,
                    working_time_monthly = process.working_time_monthly,
                    shift = process.shift,
                    worker = process.worker,
                    direct_labour_cost = process.direct_labour_cost,
                    total_labour_cost = process.total_labour_cost,
                    machine_qty = process.machine_qty,
                    area = process.area,
                    special_material = process.special_material,
                    plant_maintenance = process.plant_maintenance,
                    machine_cost = process.machine_cost,
                    total_machine_cost = process.total_machine_cost,
                    total_machine_cost_10percentage = process.total_machine_cost_10percentage,
                    consumption_kwh = process.consumption_kwh,
                    consumption_cost = process.consumption_cost,
                    consumption_rate = process.consumption_rate,
                    utility_electric = process.utility_electric,
                    machine_utility_cost = process.machine_utility_cost,
                    total_cost = process.total_cost,
                    charge_minute = process.charge_minute,
                    cycle_time_second = process.cycle_time_second,
                    time_second = process.time_second,
                    capacity = process.capacity,
                    time_g = process.time_g,
                    efficiency = process.efficiency,
                    production_capacity = process.production_capacity,
                    cycle_time_minute = process.cycle_time_minute,
                    double_process = process.double_process,
                    direct_process_cost = process.direct_process_cost,
                    labor_cost_percentage = process.labor_cost_percentage,
                    machine_cost_percentage = process.machine_cost_percentage,
                    overhead_cost_percentage = process.overhead_cost_percentage
                }).FirstOrDefault();

            return _costWithProcess;
        }


        public void AddProcess(ProcessVM process)
        {
            var _process = new Process()
            {
                doc_no = process.doc_no,
                process_name = process.process_name,
                remark = process.remark,
                working_days = process.working_days,
                working_time_daily = process.working_time_daily,
                working_time_monthly = process.working_time_monthly,
                shift = process.shift,
                worker = process.worker,
                direct_labour_cost = process.direct_labour_cost,
                total_labour_cost = process.total_labour_cost,
                machine_qty = process.machine_qty,
                area = process.area,
                special_material = process.special_material,
                plant_maintenance = process.plant_maintenance,
                machine_cost = process.machine_cost,
                total_machine_cost = process.total_machine_cost,
                total_machine_cost_10percentage = process.total_machine_cost_10percentage,
                consumption_kwh = process.consumption_kwh,
                consumption_cost = process.consumption_cost,
                consumption_rate = process.consumption_rate,
                utility_electric = process.utility_electric,
                machine_utility_cost = process.machine_utility_cost,
                total_cost = process.total_cost,
                charge_minute = process.charge_minute,
                cycle_time_second = process.cycle_time_second,
                time_second = process.time_second,
                capacity = process.capacity,
                time_g = process.time_g,
                efficiency = process.efficiency,
                production_capacity = process.production_capacity,
                cycle_time_minute = process.cycle_time_minute,
                double_process = process.double_process,
                direct_process_cost = process.direct_process_cost,
                labor_cost_percentage = process.labor_cost_percentage,
                machine_cost_percentage = process.machine_cost_percentage,
                overhead_cost_percentage = process.overhead_cost_percentage

            };

            _context.Processes.Add(_process);
            _context.SaveChanges();


        }

    }
}
