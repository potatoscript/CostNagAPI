﻿using System;
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

        [Column(TypeName = "character varying(10)")]
        public string expired_by { get; set; }

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

        [Column(TypeName = "double precision")]
        public double item_id { get; set; }

        [Column(TypeName = "double precision")]
        public double item_od { get; set; }

        [Column(TypeName = "double precision")]
        public double item_w { get; set; }

        [Column(TypeName = "double precision")]
        public double item_w2 { get; set; }

        [Column(TypeName = "character varying(20)")]
        public string business_type { get; set; }

        [Column(TypeName = "integer")]
        public int qty_month { get; set; }


        [Column(TypeName = "double precision")]
        public double exchange_rate_jpy { get; set; }

        [Column(TypeName = "double precision")]
        public double exchange_rate_usd { get; set; }

        [Column(TypeName = "double precision")]
        public double exchange_rate_eud { get; set; }


        [Column(TypeName = "double precision")]
        public double target_price_sgd { get; set; }

        [Column(TypeName = "double precision")]
        public double target_price_wr_sgd { get; set; }

        [Column(TypeName = "double precision")]
        public double target_price_usd { get; set; }

        [Column(TypeName = "double precision")]
        public double target_price_wr_usd { get; set; }

        [Column(TypeName = "double precision")]
        public double target_price_eud { get; set; }

        [Column(TypeName = "double precision")]
        public double target_price_wr_eud { get; set; }




        [Column(TypeName = "integer")]
        public double production_qty_day { get; set; }

        [Column(TypeName = "integer")]
        public double working_day { get; set; }

        [Column(TypeName = "character varying(100)")]
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



        [Column(TypeName = "character varying(100)")]
        public string rubber_material_name2 { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_database_price_current2 { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_database_price_new2 { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_price_kg2 { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_mixing_process_cost2 { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_weight_g2 { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_weight_kg2 { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_yield_rate2 { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_weight_kg_yieldrate2 { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_cost_sgd2 { get; set; }

        [Column(TypeName = "double precision")]
        public double rubber_percentage_target_price2 { get; set; }

        /// <summary>
        /// /////////////Material Inhouse
        /// </summary>
        [Column(TypeName = "character varying(30)")]
        public string material_inhouse_name_1 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string material_inhouse_info_1 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_value_1 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string material_inhouse_info_1b { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_value_1b { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_cost_sgd_1 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_percentage_target_price_1 { get; set; }

        [Column(TypeName = "character varying(30)")]
        public string material_inhouse_name_2 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string material_inhouse_info_2 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_value_2 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string material_inhouse_info_2b { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_value_2b { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_cost_sgd_2 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_percentage_target_price_2 { get; set; }

        [Column(TypeName = "character varying(30)")]
        public string material_inhouse_name_3 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string material_inhouse_info_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_value_3 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string material_inhouse_info_3b { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_value_3b { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_cost_sgd_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_inhouse_percentage_target_price_3 { get; set; }


        ////////////Material Outside
        [Column(TypeName = "character varying(30)")]
        public string material_outside_name_1 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string material_outside_info_1 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_value_1 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string material_outside_info_1b { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_value_1b { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_cost_sgd_1 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_percentage_target_price_1 { get; set; }

        [Column(TypeName = "character varying(30)")]
        public string material_outside_name_2 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string material_outside_info_2 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_value_2 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string material_outside_info_2b { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_value_2b { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_cost_sgd_2 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_percentage_target_price_2 { get; set; }

        [Column(TypeName = "character varying(30)")]
        public string material_outside_name_3 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string material_outside_info_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_value_3 { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string material_outside_info_3b { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_value_3b { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_cost_sgd_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double material_outside_percentage_target_price_3 { get; set; }

        /// <summary>
        /// Direct Material 
        /// </summary>

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
        public double special_package_cost { get; set; }

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


        ////Machine & Tooling List
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_1 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_1 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_1 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_1 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_1 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_1 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_1 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_1 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_1 { get; set; }


        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_2 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_2 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_2 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_2 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_2 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_2 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_2 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_2 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_2 { get; set; }

        ///no 3
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_3 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_3 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_3 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_3 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_3 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_3 { get; set; }

        // no 4
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_4 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_4 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_4 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_4 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_4 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_4 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_4 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_4 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_4 { get; set; }

        // no 5
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_5 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_5 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_5 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_5 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_5 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_5 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_5 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_5 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_5 { get; set; }


        //no 6
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_6 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_6 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_6 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_6 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_6 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_6 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_6 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_6 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_6 { get; set; }

        //no 7
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_7 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_7 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_7 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_7 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_7 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_7 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_7 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_7 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_7 { get; set; }

        //no 8
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_8 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_8 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_8 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_8 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_8 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_8 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_8 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_8 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_8 { get; set; }

        //no 9
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_9 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_9 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_9 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_9 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_9 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_9 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_9 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_9 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_9 { get; set; }

        //no 10
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_10 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_10 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_10 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_10 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_10 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_10 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_10 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_10 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_10 { get; set; }

        //no 11
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_11 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_11 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_11 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_11 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_11 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_11 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_11 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_11 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_11 { get; set; }

        //no 12
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_12 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_12 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_12 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_12 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_12 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_12 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_12 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_12 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_12 { get; set; }

        //no 13
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_13 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_13 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_13 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_13 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_13 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_13 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_13 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_13 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_13 { get; set; }

        //no 14
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_14 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_14 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_14 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_14 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_14 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_14 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_14 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_14 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_14 { get; set; }

        //no 15
        [Column(TypeName = "character varying(50)")]
        public string tooling_list_description_15 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_type_15 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_source_15 { get; set; }

        [Column(TypeName = "integer")]
        public int tooling_list_qty_15 { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string tooling_list_unit_15 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_price_15 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_jpy_15 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_usd_15 { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_amount_sgd_15 { get; set; }

        //total machine and tooling list
        [Column(TypeName = "double precision")]
        public double tooling_list_total_amount_usd { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_list_total_amount_sgd { get; set; }


        //Raw Material Cost
        [Column(TypeName = "double precision")]
        public double direct_raw_material { get; set; }

        [Column(TypeName = "double precision")]
        public double direct_raw_material_p { get; set; }

        [Column(TypeName = "double precision")]
        public double sub_material { get; set; }

        [Column(TypeName = "double precision")]
        public double sub_material_p { get; set; }

        [Column(TypeName = "double precision")]
        public double raw_material_cost_sub_total { get; set; }

        [Column(TypeName = "double precision")]
        public double raw_material_cost_sub_total_p { get; set; }


        //Breakdown of Process Cost
        [Column(TypeName = "double precision")]
        public double labor_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double labor_cost_p { get; set; }

        [Column(TypeName = "double precision")]
        public double machine_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double machine_cost_p { get; set; }

        [Column(TypeName = "double precision")]
        public double overhead_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double overhead_cost_p { get; set; }

        [Column(TypeName = "double precision")]
        public double process_cost_sub_total { get; set; }

        [Column(TypeName = "double precision")]
        public double process_cost_sub_total_p { get; set; }

        [Column(TypeName = "double precision")]
        public double defectives { get; set; }

        [Column(TypeName = "double precision")]
        public double defectives_p { get; set; }

        [Column(TypeName = "double precision")]
        public double admin_engin_qc { get; set; }

        [Column(TypeName = "double precision")]
        public double admin_engin_qc_p { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double tooling_cost_p { get; set; }

        [Column(TypeName = "double precision")]
        public double process_margin_adjust { get; set; }

        [Column(TypeName = "double precision")]
        public double process_margin_adjust_p { get; set; }

        [Column(TypeName = "double precision")]
        public double other_fixed_cost_sub_total { get; set; }

        [Column(TypeName = "double precision")]
        public double other_fixed_cost_sub_total_p { get; set; }

        [Column(TypeName = "double precision")]
        public double grand_total_cost { get; set; }

        [Column(TypeName = "double precision")]
        public double grand_total_cost_p { get; set; }


        [Column(TypeName = "double precision")]
        public double production_capacity { get; set; }

        [Column(TypeName = "double precision")]
        public double actual_working_time { get; set; }

        [Column(TypeName = "double precision")]
        public double cycle_time { get; set; }

        [Column(TypeName = "double precision")]
        public double efficiency { get; set; }

        [Column(TypeName = "double precision")]
        public double daily_qty_days { get; set; }

        [Column(TypeName = "double precision")]
        public double daily_qty_days_p { get; set; }

        [Column(TypeName = "double precision")]
        public double daily_amount { get; set; }


        //Navigation Properties
        public List<CostProcess> Cost_Processes { get; set; }






    }




}























