using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAGAPI.ViewModels
{
    public class ProcessMasterVM
    {
        public int ProcessMasterId { get; set; }

        public string process_name { get; set; }
        public string process_type { get; set; }

        public double od_min { get; set; }

        public double od_max { get; set; }

        public double overhead_cost { get; set; }

        public double machine_cost { get; set; }

        public double labor_cost { get; set; }

        public double total_cost { get; set; }

        public List<ProcessVM> ProcessMasters { get; set; }
    }
}
