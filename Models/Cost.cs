using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAGAPI.Models
{
    public class Cost
    {

        public int CostId { get; set; }

        [Column(TypeName = "character varying(5)")]
        public string plant { get; set; }

        [Column(TypeName = "character varying(20)")]
        public string item_spec { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string issue_date { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string section { get; set; }

        [Column(TypeName = "character varying(20)")]
        public string doc_no { get; set; }

        [Column(TypeName = "character varying(20)")]
        public string wr_no { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string sales { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string revision_no { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string checked_date { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string approved_by { get; set; }

        [Column(TypeName = "character varying(20)")]
        public string customer { get; set; }

        [Column(TypeName = "character varying(15)")]
        public string parts_code { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string item { get; set; }

        [Column(TypeName = "character varying(20)")]
        public string product { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string product_type { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string size { get; set; }

        [Column(TypeName = "character varying(20)")]
        public string business_type { get; set; }

        [Column(TypeName = "integer")]
        public int qty_month { get; set; }

        [Column(TypeName = "double precision")]
        public double exchange_rate { get; set; }

        [Column(TypeName = "double precision")]
        public double target_price_bht { get; set; }

        [Column(TypeName = "double precision")]
        public double target_price_export { get; set; }

        [Column(TypeName = "integer")]
        public double production_qty_day { get; set; }

        [Column(TypeName = "integer")]
        public double working_day { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string rubber_material_name  { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_database_price_current { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_database_price_new { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_price_kg { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_mixing_process_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_weight_g { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_weight_kg { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_yield_rate { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_weight_kg_yieldrate { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_cost_sgd { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_percentage_target_price { get; set; }

/// <summary>
/// /////////////Material Inhouse
/// </summary>
        [Column(TypeName = "character varying(30)")]
        public double material_inhouse_name_1 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public double material_inhouse_info_1 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_cost_sgd_1 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_percentage_target_price_1 { get; set; }

        [Column(TypeName = "character varying(30)")]
        public double material_inhouse_name_2 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public double material_inhouse_info_2 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_cost_sgd_2 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_percentage_target_price_2 { get; set; }

        [Column(TypeName = "character varying(30)")]
        public double material_inhouse_name_3 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public double material_inhouse_info_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_cost_sgd_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_percentage_target_price_3 { get; set; }


        ////////////Material Outside
        [Column(TypeName = "character varying(30)")]
        public double material_outside_name_1 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public double material_outside_info_1 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_cost_sgd_1 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_percentage_target_price_1 { get; set; }

        [Column(TypeName = "character varying(30)")]
        public double material_outside_name_2 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public double material_outside_info_2 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_cost_sgd_2 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_percentage_target_price_2 { get; set; }

        [Column(TypeName = "character varying(30)")]
        public double material_outside_name_3 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public double material_outside_info_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_cost_sgd_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_percentage_target_price_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double direct_material_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double direct_material_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double sub_material_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double sub_material_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double sub_material_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double direct_process_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double direct_process_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double total_direct_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double total_direct_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double defective_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double defective_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double defective_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double indirect_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double indirect_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double indirect_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double packing_material_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double packing_material_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double packing_material_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double administration_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double administration_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double administration_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double plant_retail_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double plant_retail_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double plant_retail_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double moldjig_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double moldjig_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double moldjig_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double die_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double die_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double die_cost_percentage { get; set; }

        [Column(TypeName = "character varying(200)")]
        public string note { get; set; }

        [Column(TypeName = "double precision")]
        public double net_included_tooling_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double net_included_tooling_cost_percentage { get; set; }

        [Column(TypeName = "double precision")]
        public double net_exclude_tooling_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double net_exclude_tooling_cost_percentage { get; set; }
    }
}



















