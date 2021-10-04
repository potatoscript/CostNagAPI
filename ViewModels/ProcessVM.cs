using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CostNAGAPI.ViewModels
{
    public class ProcessVM
    {
        [Column(TypeName = "character varying(20)")]
        public string doc_no { get; set; }

        [Column(TypeName = "character varying(20)")]
        public string process_name { get; set; }

        [Column(TypeName = "character varying(20)")]
        public string remark { get; set; }

        [Column(TypeName = "integer")]
        public int working_days { get; set; }

        [Column(TypeName = "double precision")]
        public double working_time_daily { get; set; }

        [Column(TypeName = "double precision")]
        public double working_time_monthly { get; set; }

        [Column(TypeName = "integer")]
        public int shift { get; set; }

        [Column(TypeName = "double precision")]
        public double worker { get; set; }

        [Column(TypeName = "double precision")]
        public double direct_labour_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double total_labour_cost { get; set; }

        [Column(TypeName = "integer")]
        public int machine_qty { get; set; }

        [Column(TypeName = "double precision")]
        public double area { get; set; }

        [Column(TypeName = "double precision")]
        public double special_material { get; set; }

        [Column(TypeName = "double precision")]
        public double plant_maintenance { get; set; }

        [Column(TypeName = "double precision")]
        public double machine_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double total_machine_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double total_machine_cost_10percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double consumption_kwh { get; set; }

        [Column(TypeName = "double precision")]
        public double consumption_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double consumption_rate { get; set; }

        [Column(TypeName = "double precision")]
        public double utility_electric { get; set; }

        [Column(TypeName = "double precision")]
        public double machine_utility_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double total_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double charge_minute { get; set; }

        [Column(TypeName = "double precision")]
        public double cycle_time_second { get; set; }

        [Column(TypeName = "double precision")]
        public double time_second { get; set; }

        [Column(TypeName = "double precision")]
        public double capacity { get; set; }

        [Column(TypeName = "double precision")]
        public double time_g { get; set; }

        [Column(TypeName = "double precision")]
        public double efficiency { get; set; }

        [Column(TypeName = "double precision")]
        public double production_capacity { get; set; }

        [Column(TypeName = "double precision")]
        public double cycle_time_minute { get; set; }

        [Column(TypeName = "double precision")]
        public double double_process { get; set; }

        [Column(TypeName = "double precision")]
        public double direct_process_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double labor_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double machine_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double overhead_cost_percentage { get; set; }
    }

    


}
