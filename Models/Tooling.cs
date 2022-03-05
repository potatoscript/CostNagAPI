using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CostNAGAPI.Models
{
    public class Tooling
    {
        public int ToolingId { get; set; }

        [Column(TypeName = "character varying(100)")]
        public string description { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string source { get; set; }

        [Column(TypeName = "double precision")]
        public double qty { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string unit{ get; set; }

        [Column(TypeName = "double precision")]
        public double price { get; set; }

        [Column(TypeName = "double precision")]
        public double od { get; set; }

        [Column(TypeName = "double precision")]
        public double od_max { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string type { get; set; }
    }
}
