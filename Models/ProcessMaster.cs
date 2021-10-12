using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAGAPI.Models
{
    public class ProcessMaster
    {
        public int ProcessMasterId { get; set; }

        [Column(TypeName = "character varying(100)")]
        public string process_name { get; set; }

        [Column(TypeName = "double precision")]
        public double od_min { get; set; }

        [Column(TypeName = "double precision")]
        public double od_max { get; set; }

        [Column(TypeName = "double precision")]
        public double overhead_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double machine_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double labor_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double total_cost { get; set; }

    }
}








