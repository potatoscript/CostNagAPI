using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAGAPI.Models
{
    public class Cost_Process
    {
        public int Id { get; set; }

        public int CostId { get; set; }
        public Cost Cost { get; set; }


        public int ProcessId { get; set; }
        public Process Process { get; set; }

    }
}
