using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAGAPI.Models
{
    public class Rubber
    {
        public int RubberId { get; set; }

        [Column(TypeName = "character varying(100)")]
        public string material_name { get; set; }

        [Column(TypeName = "double precision")]
        public double price_kg { get; set; }

        [Column(TypeName = "double precision")]
        public double mixing_process_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double weight_g { get; set; }

        [Column(TypeName = "double precision")]
        public double yield_rate { get; set; }

    }
}






