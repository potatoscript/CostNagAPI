using CostNAG.Models;
using CostNAGAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAGAPI.Services
{
    public class CostService
    {
        private CostDbContext _context;
        public CostService(CostDbContext context)
        {
            _context = context;
        }

        public void AddCost(Cost cost)
        {
            var _cost = new Cost()
            {
                plant = cost.plant,
                item_spec = cost.item_spec,
                issue_date = cost.issue_date,
                section = cost.section,
                doc_no = cost.doc_no,
                wr_no = cost.wr_no,
                sales = cost.sales,
                revision_no = cost.revision_no,
                checked_date = cost.checked_date,
                approved_by = cost.approved_by,
                expired_by = cost.expired_by,
                customer = cost.customer,
                parts_code = cost.parts_code,
                item = cost.item,
                product = cost.product,
                product_type = cost.product_type,
                size = cost.size,
                item_id = cost.item_id,
                item_od = cost.item_od,
                item_w = cost.item_w,
                business_type = cost.business_type,
                qty_month = cost.qty_month,
                exchange_rate = cost.exchange_rate,
                target_price_bht = cost.target_price_bht,
                target_price_export = cost.target_price_export,
                production_qty_day = cost.production_qty_day,
                working_day = cost.working_day,
                rubber_material_name = cost.rubber_material_name,
                rubber_database_price_current = cost.rubber_database_price_current,
                rubber_database_price_new = cost.rubber_database_price_new,
                rubber_price_kg = cost.rubber_price_kg,
                rubber_mixing_process_cost = cost.rubber_mixing_process_cost,
                rubber_weight_g = cost.rubber_weight_g,
                rubber_weight_kg = cost.rubber_weight_kg,
                rubber_yield_rate = cost.rubber_yield_rate,
                rubber_weight_kg_yieldrate = cost.rubber_weight_kg_yieldrate,
                rubber_cost_sgd = cost.rubber_cost_sgd,
                rubber_percentage_target_price = cost.rubber_percentage_target_price,

                material_inhouse_name_1 = cost.material_inhouse_name_1,
                material_inhouse_info_1 = cost.material_inhouse_info_1,
                material_inhouse_value_1 = cost.material_inhouse_value_1,
                material_inhouse_info_1b = cost.material_inhouse_info_1b,
                material_inhouse_value_1b = cost.material_inhouse_value_1b,
                material_inhouse_cost_sgd_1 = cost.material_inhouse_cost_sgd_1,
                material_inhouse_percentage_target_price_1 = cost.material_inhouse_percentage_target_price_1,
                material_inhouse_name_2 = cost.material_inhouse_name_2,
                material_inhouse_info_2 = cost.material_inhouse_info_2,
                material_inhouse_value_2 = cost.material_inhouse_value_2,
                material_inhouse_info_2b = cost.material_inhouse_info_2b,
                material_inhouse_value_2b = cost.material_inhouse_value_2b,
                material_inhouse_cost_sgd_2 = cost.material_inhouse_cost_sgd_2,
                material_inhouse_percentage_target_price_2 = cost.material_inhouse_percentage_target_price_2,
                material_inhouse_name_3 = cost.material_inhouse_name_3,
                material_inhouse_info_3 = cost.material_inhouse_info_3,
                material_inhouse_value_3 = cost.material_inhouse_value_3,
                material_inhouse_info_3b = cost.material_inhouse_info_3b,
                material_inhouse_value_3b = cost.material_inhouse_value_3b,
                material_inhouse_cost_sgd_3 = cost.material_inhouse_cost_sgd_3,
                material_inhouse_percentage_target_price_3 = cost.material_inhouse_percentage_target_price_3,

                material_outside_name_1 = cost.material_outside_name_1,
                material_outside_info_1 = cost.material_outside_info_1,
                material_outside_value_1 = cost.material_outside_value_1,
                material_outside_info_1b = cost.material_outside_info_1b,
                material_outside_value_1b = cost.material_outside_value_1b,
                material_outside_cost_sgd_1 = cost.material_outside_cost_sgd_1,
                material_outside_percentage_target_price_1 = cost.material_outside_percentage_target_price_1,
                material_outside_name_2 = cost.material_outside_name_2,
                material_outside_info_2 = cost.material_outside_info_2,
                material_outside_value_2 = cost.material_outside_value_2,
                material_outside_info_2b = cost.material_outside_info_2b,
                material_outside_value_2b = cost.material_outside_value_2b,
                material_outside_cost_sgd_2 = cost.material_outside_cost_sgd_2,
                material_outside_percentage_target_price_2 = cost.material_outside_percentage_target_price_2,
                material_outside_name_3 = cost.material_outside_name_3,
                material_outside_info_3 = cost.material_outside_info_3,
                material_outside_value_3 = cost.material_outside_value_3,
                material_outside_info_3b = cost.material_outside_info_3b,
                material_outside_value_3b = cost.material_outside_value_3b,
                material_outside_cost_sgd_3 = cost.material_outside_cost_sgd_3,
                material_outside_percentage_target_price_3 = cost.material_outside_percentage_target_price_3,

                direct_material_cost = cost.direct_material_cost,
                direct_material_cost_percentage = cost.direct_material_cost_percentage,
                sub_material_percentage = cost.sub_material_percentage,
                sub_material_cost = cost.sub_material_cost,
                sub_material_cost_percentage = cost.sub_material_cost_percentage,
                direct_process_cost = cost.direct_process_cost,
                direct_process_cost_percentage = cost.direct_process_cost_percentage,
                total_direct_cost = cost.total_direct_cost,
                total_direct_cost_percentage = cost.total_direct_cost_percentage,
                defective_percentage = cost.defective_percentage,
                defective_cost = cost.defective_cost,
                defective_cost_percentage = cost.defective_cost_percentage,
                indirect_percentage = cost.indirect_percentage,
                indirect_cost = cost.indirect_cost,
                indirect_cost_percentage = cost.indirect_cost_percentage,
                packing_material_percentage = cost.packing_material_percentage,
                special_package_cost = cost.special_package_cost,
                packing_material_cost = cost.packing_material_cost,
                packing_material_cost_percentage = cost.packing_material_cost_percentage,
                administration_percentage = cost.administration_percentage,
                administration_cost = cost.administration_cost,
                administration_cost_percentage = cost.administration_cost_percentage,
                plant_retail_percentage = cost.plant_retail_percentage,
                plant_retail_cost = cost.plant_retail_cost,
                plant_retail_cost_percentage = cost.plant_retail_cost_percentage,
                moldjig_percentage = cost.moldjig_percentage,
                moldjig_cost = cost.moldjig_cost,
                moldjig_cost_percentage = cost.moldjig_cost_percentage,
                die_percentage = cost.die_percentage,
                die_cost = cost.die_cost,
                die_cost_percentage = cost.die_cost_percentage,
                note = cost.note,
                net_included_tooling_cost = cost.net_included_tooling_cost,
                net_included_tooling_cost_percentage = cost.net_included_tooling_cost_percentage,
                net_exclude_tooling_cost = cost.net_exclude_tooling_cost,
                net_exclude_tooling_cost_percentage = cost.net_exclude_tooling_cost_percentage,

                tooling_list_description_1 = cost.tooling_list_description_1,
                tooling_list_type_1 = cost.tooling_list_type_1,
                tooling_list_source_1 = cost.tooling_list_source_1,
                tooling_list_qty_1 = cost.tooling_list_qty_1,
                tooling_list_unit_1 = cost.tooling_list_unit_1,
                tooling_list_price_1 = cost.tooling_list_price_1,
                tooling_list_amount_jpy_1 = cost.tooling_list_amount_jpy_1,
                tooling_list_amount_usd_1 = cost.tooling_list_amount_usd_1,

                tooling_list_description_2 = cost.tooling_list_description_2,
                tooling_list_type_2 = cost.tooling_list_type_2,
                tooling_list_source_2 = cost.tooling_list_source_2,
                tooling_list_qty_2 = cost.tooling_list_qty_2,
                tooling_list_unit_2 = cost.tooling_list_unit_2,
                tooling_list_price_2 = cost.tooling_list_price_2,
                tooling_list_amount_jpy_2 = cost.tooling_list_amount_jpy_2,
                tooling_list_amount_usd_2 = cost.tooling_list_amount_usd_2,

                tooling_list_description_3 = cost.tooling_list_description_3,
                tooling_list_type_3 = cost.tooling_list_type_3,
                tooling_list_source_3 = cost.tooling_list_source_3,
                tooling_list_qty_3 = cost.tooling_list_qty_3,
                tooling_list_unit_3 = cost.tooling_list_unit_3,
                tooling_list_price_3 = cost.tooling_list_price_3,
                tooling_list_amount_jpy_3 = cost.tooling_list_amount_jpy_3,
                tooling_list_amount_usd_3 = cost.tooling_list_amount_usd_3,

                tooling_list_description_4 = cost.tooling_list_description_4,
                tooling_list_type_4 = cost.tooling_list_type_4,
                tooling_list_source_4 = cost.tooling_list_source_4,
                tooling_list_qty_4 = cost.tooling_list_qty_4,
                tooling_list_unit_4 = cost.tooling_list_unit_4,
                tooling_list_price_4 = cost.tooling_list_price_4,
                tooling_list_amount_jpy_4 = cost.tooling_list_amount_jpy_4,
                tooling_list_amount_usd_4 = cost.tooling_list_amount_usd_4,

                tooling_list_description_5 = cost.tooling_list_description_5,
                tooling_list_type_5 = cost.tooling_list_type_5,
                tooling_list_source_5 = cost.tooling_list_source_5,
                tooling_list_qty_5 = cost.tooling_list_qty_5,
                tooling_list_unit_5 = cost.tooling_list_unit_5,
                tooling_list_price_5 = cost.tooling_list_price_5,
                tooling_list_amount_jpy_5 = cost.tooling_list_amount_jpy_5,
                tooling_list_amount_usd_5 = cost.tooling_list_amount_usd_5,

                tooling_list_description_6 = cost.tooling_list_description_6,
                tooling_list_type_6 = cost.tooling_list_type_6,
                tooling_list_source_6 = cost.tooling_list_source_6,
                tooling_list_qty_6 = cost.tooling_list_qty_6,
                tooling_list_unit_6 = cost.tooling_list_unit_6,
                tooling_list_price_6 = cost.tooling_list_price_6,
                tooling_list_amount_jpy_6 = cost.tooling_list_amount_jpy_6,
                tooling_list_amount_usd_6 = cost.tooling_list_amount_usd_6,

                tooling_list_description_7 = cost.tooling_list_description_7,
                tooling_list_type_7 = cost.tooling_list_type_7,
                tooling_list_source_7 = cost.tooling_list_source_7,
                tooling_list_qty_7 = cost.tooling_list_qty_7,
                tooling_list_unit_7 = cost.tooling_list_unit_7,
                tooling_list_price_7 = cost.tooling_list_price_7,
                tooling_list_amount_jpy_7 = cost.tooling_list_amount_jpy_7,
                tooling_list_amount_usd_7 = cost.tooling_list_amount_usd_7,

                tooling_list_description_8 = cost.tooling_list_description_8,
                tooling_list_type_8 = cost.tooling_list_type_8,
                tooling_list_source_8 = cost.tooling_list_source_8,
                tooling_list_qty_8 = cost.tooling_list_qty_8,
                tooling_list_unit_8 = cost.tooling_list_unit_8,
                tooling_list_price_8 = cost.tooling_list_price_8,
                tooling_list_amount_jpy_8 = cost.tooling_list_amount_jpy_8,
                tooling_list_amount_usd_8 = cost.tooling_list_amount_usd_8,

                tooling_list_description_9 = cost.tooling_list_description_9,
                tooling_list_type_9 = cost.tooling_list_type_9,
                tooling_list_source_9 = cost.tooling_list_source_9,
                tooling_list_qty_9 = cost.tooling_list_qty_9,
                tooling_list_unit_9 = cost.tooling_list_unit_9,
                tooling_list_price_9 = cost.tooling_list_price_9,
                tooling_list_amount_jpy_9 = cost.tooling_list_amount_jpy_9,
                tooling_list_amount_usd_9 = cost.tooling_list_amount_usd_9,

                tooling_list_description_10 = cost.tooling_list_description_10,
                tooling_list_type_10 = cost.tooling_list_type_10,
                tooling_list_source_10 = cost.tooling_list_source_10,
                tooling_list_qty_10 = cost.tooling_list_qty_10,
                tooling_list_unit_10 = cost.tooling_list_unit_10,
                tooling_list_price_10 = cost.tooling_list_price_10,
                tooling_list_amount_jpy_10 = cost.tooling_list_amount_jpy_10,
                tooling_list_amount_usd_10 = cost.tooling_list_amount_usd_10,

                tooling_list_description_11 = cost.tooling_list_description_11,
                tooling_list_type_11 = cost.tooling_list_type_11,
                tooling_list_source_11 = cost.tooling_list_source_11,
                tooling_list_qty_11 = cost.tooling_list_qty_11,
                tooling_list_unit_11 = cost.tooling_list_unit_11,
                tooling_list_price_11 = cost.tooling_list_price_11,
                tooling_list_amount_jpy_11 = cost.tooling_list_amount_jpy_11,
                tooling_list_amount_usd_11 = cost.tooling_list_amount_usd_11,

                tooling_list_description_12 = cost.tooling_list_description_12,
                tooling_list_type_12 = cost.tooling_list_type_12,
                tooling_list_source_12 = cost.tooling_list_source_12,
                tooling_list_qty_12 = cost.tooling_list_qty_12,
                tooling_list_unit_12 = cost.tooling_list_unit_12,
                tooling_list_price_12 = cost.tooling_list_price_12,
                tooling_list_amount_jpy_12 = cost.tooling_list_amount_jpy_12,
                tooling_list_amount_usd_12 = cost.tooling_list_amount_usd_12,

                tooling_list_description_13 = cost.tooling_list_description_13,
                tooling_list_type_13 = cost.tooling_list_type_13,
                tooling_list_source_13 = cost.tooling_list_source_13,
                tooling_list_qty_13 = cost.tooling_list_qty_13,
                tooling_list_unit_13 = cost.tooling_list_unit_13,
                tooling_list_price_13 = cost.tooling_list_price_13,
                tooling_list_amount_jpy_13 = cost.tooling_list_amount_jpy_13,
                tooling_list_amount_usd_13 = cost.tooling_list_amount_usd_13,

                tooling_list_description_14 = cost.tooling_list_description_14,
                tooling_list_type_14 = cost.tooling_list_type_14,
                tooling_list_source_14 = cost.tooling_list_source_14,
                tooling_list_qty_14 = cost.tooling_list_qty_14,
                tooling_list_unit_14 = cost.tooling_list_unit_14,
                tooling_list_price_14 = cost.tooling_list_price_14,
                tooling_list_amount_jpy_14 = cost.tooling_list_amount_jpy_14,
                tooling_list_amount_usd_14 = cost.tooling_list_amount_usd_14,

                tooling_list_description_15 = cost.tooling_list_description_15,
                tooling_list_type_15 = cost.tooling_list_type_15,
                tooling_list_source_15 = cost.tooling_list_source_15,
                tooling_list_qty_15 = cost.tooling_list_qty_15,
                tooling_list_unit_15 = cost.tooling_list_unit_15,
                tooling_list_price_15 = cost.tooling_list_price_15,
                tooling_list_amount_jpy_15 = cost.tooling_list_amount_jpy_15,
                tooling_list_amount_usd_15 = cost.tooling_list_amount_usd_15,

                tooling_list_total_amount_usd = cost.tooling_list_total_amount_usd
            };

            _context.Costs.Add(_cost);
            _context.SaveChanges();

        }

       



        //public List<Cost> GetAllCost()
        //{
        //    return _context.Costs.ToList();
        //}
        public List<Cost> GetAllCost() => _context.Costs.ToList();

        public List<Cost> GetAllDocNo()
        {
            return _context.Costs.Select(m => new Cost() { doc_no=m.doc_no }).Distinct().ToList();
        }

        //public Cost GetCostById(int costId) => _context.Costs.FirstOrDefault(n => n.CostId == costId);
        public Cost GetCostById(int costId)
        {
            var _costWithProcess = _context.Costs
                .Where(n => n.CostId == costId)
                .Select(cost => new Cost()
            {
                plant = cost.plant,
                item_spec = cost.item_spec,
                issue_date = cost.issue_date,
                section = cost.section,
                doc_no = cost.doc_no,
                wr_no = cost.wr_no,
                sales = cost.sales,
                revision_no = cost.revision_no,
                checked_date = cost.checked_date,
                approved_by = cost.approved_by,
                expired_by = cost.expired_by,
                customer = cost.customer,
                parts_code = cost.parts_code,
                item = cost.item,
                product = cost.product,
                product_type = cost.product_type,
                size = cost.size,
                item_id = cost.item_id,
                item_od = cost.item_od,
                item_w = cost.item_w,
                business_type = cost.business_type,
                qty_month = cost.qty_month,
                exchange_rate = cost.exchange_rate,
                target_price_bht = cost.target_price_bht,
                target_price_export = cost.target_price_export,
                production_qty_day = cost.production_qty_day,
                working_day = cost.working_day,
                rubber_material_name = cost.rubber_material_name,
                rubber_database_price_current = cost.rubber_database_price_current,
                rubber_database_price_new = cost.rubber_database_price_new,
                rubber_price_kg = cost.rubber_price_kg,
                rubber_mixing_process_cost = cost.rubber_mixing_process_cost,
                rubber_weight_g = cost.rubber_weight_g,
                rubber_weight_kg = cost.rubber_weight_kg,
                rubber_yield_rate = cost.rubber_yield_rate,
                rubber_weight_kg_yieldrate = cost.rubber_weight_kg_yieldrate,
                rubber_cost_sgd = cost.rubber_cost_sgd,
                rubber_percentage_target_price = cost.rubber_percentage_target_price,

                material_inhouse_name_1 = cost.material_inhouse_name_1,
                material_inhouse_info_1 = cost.material_inhouse_info_1,
                material_inhouse_value_1 = cost.material_inhouse_value_1,
                material_inhouse_info_1b = cost.material_inhouse_info_1b,
                material_inhouse_value_1b = cost.material_inhouse_value_1b,
                material_inhouse_cost_sgd_1 = cost.material_inhouse_cost_sgd_1,
                material_inhouse_percentage_target_price_1 = cost.material_inhouse_percentage_target_price_1,
                material_inhouse_name_2 = cost.material_inhouse_name_2,
                material_inhouse_info_2 = cost.material_inhouse_info_2,
                material_inhouse_value_2 = cost.material_inhouse_value_2,
                material_inhouse_info_2b = cost.material_inhouse_info_2b,
                material_inhouse_value_2b = cost.material_inhouse_value_2b,
                material_inhouse_cost_sgd_2 = cost.material_inhouse_cost_sgd_2,
                material_inhouse_percentage_target_price_2 = cost.material_inhouse_percentage_target_price_2,
                material_inhouse_name_3 = cost.material_inhouse_name_3,
                material_inhouse_info_3 = cost.material_inhouse_info_3,
                material_inhouse_value_3 = cost.material_inhouse_value_3,
                material_inhouse_info_3b = cost.material_inhouse_info_3b,
                material_inhouse_value_3b = cost.material_inhouse_value_3b,
                material_inhouse_cost_sgd_3 = cost.material_inhouse_cost_sgd_3,
                material_inhouse_percentage_target_price_3 = cost.material_inhouse_percentage_target_price_3,

                material_outside_name_1 = cost.material_outside_name_1,
                material_outside_info_1 = cost.material_outside_info_1,
                material_outside_value_1 = cost.material_outside_value_1,
                material_outside_info_1b = cost.material_outside_info_1b,
                material_outside_value_1b = cost.material_outside_value_1b,
                material_outside_cost_sgd_1 = cost.material_outside_cost_sgd_1,
                material_outside_percentage_target_price_1 = cost.material_outside_percentage_target_price_1,
                material_outside_name_2 = cost.material_outside_name_2,
                material_outside_info_2 = cost.material_outside_info_2,
                material_outside_value_2 = cost.material_outside_value_2,
                material_outside_info_2b = cost.material_outside_info_2b,
                material_outside_value_2b = cost.material_outside_value_2b,
                material_outside_cost_sgd_2 = cost.material_outside_cost_sgd_2,
                material_outside_percentage_target_price_2 = cost.material_outside_percentage_target_price_2,
                material_outside_name_3 = cost.material_outside_name_3,
                material_outside_info_3 = cost.material_outside_info_3,
                material_outside_value_3 = cost.material_outside_value_3,
                material_outside_info_3b = cost.material_outside_info_3b,
                material_outside_value_3b = cost.material_outside_value_3b,
                material_outside_cost_sgd_3 = cost.material_outside_cost_sgd_3,
                material_outside_percentage_target_price_3 = cost.material_outside_percentage_target_price_3,

                direct_material_cost = cost.direct_material_cost,
                direct_material_cost_percentage = cost.direct_material_cost_percentage,
                sub_material_percentage = cost.sub_material_percentage,
                sub_material_cost = cost.sub_material_cost,
                sub_material_cost_percentage = cost.sub_material_cost_percentage,
                direct_process_cost = cost.direct_process_cost,
                direct_process_cost_percentage = cost.direct_process_cost_percentage,
                total_direct_cost = cost.total_direct_cost,
                total_direct_cost_percentage = cost.total_direct_cost_percentage,
                defective_percentage = cost.defective_percentage,
                defective_cost = cost.defective_cost,
                defective_cost_percentage = cost.defective_cost_percentage,
                indirect_percentage = cost.indirect_percentage,
                indirect_cost = cost.indirect_cost,
                indirect_cost_percentage = cost.indirect_cost_percentage,
                packing_material_percentage = cost.packing_material_percentage,
                special_package_cost = cost.special_package_cost,
                packing_material_cost = cost.packing_material_cost,
                packing_material_cost_percentage = cost.packing_material_cost_percentage,
                administration_percentage = cost.administration_percentage,
                administration_cost = cost.administration_cost,
                administration_cost_percentage = cost.administration_cost_percentage,
                plant_retail_percentage = cost.plant_retail_percentage,
                plant_retail_cost = cost.plant_retail_cost,
                plant_retail_cost_percentage = cost.plant_retail_cost_percentage,
                moldjig_percentage = cost.moldjig_percentage,
                moldjig_cost = cost.moldjig_cost,
                moldjig_cost_percentage = cost.moldjig_cost_percentage,
                die_percentage = cost.die_percentage,
                die_cost = cost.die_cost,
                die_cost_percentage = cost.die_cost_percentage,
                note = cost.note,
                net_included_tooling_cost = cost.net_included_tooling_cost,
                net_included_tooling_cost_percentage = cost.net_included_tooling_cost_percentage,
                net_exclude_tooling_cost = cost.net_exclude_tooling_cost,
                net_exclude_tooling_cost_percentage = cost.net_exclude_tooling_cost_percentage,

                tooling_list_description_1 = cost.tooling_list_description_1,
                tooling_list_type_1 = cost.tooling_list_type_1,
                tooling_list_source_1 = cost.tooling_list_source_1,
                tooling_list_qty_1 = cost.tooling_list_qty_1,
                tooling_list_unit_1 = cost.tooling_list_unit_1,
                tooling_list_price_1 = cost.tooling_list_price_1,
                tooling_list_amount_jpy_1 = cost.tooling_list_amount_jpy_1,
                tooling_list_amount_usd_1 = cost.tooling_list_amount_usd_1,

                tooling_list_description_2 = cost.tooling_list_description_2,
                tooling_list_type_2 = cost.tooling_list_type_2,
                tooling_list_source_2 = cost.tooling_list_source_2,
                tooling_list_qty_2 = cost.tooling_list_qty_2,
                tooling_list_unit_2 = cost.tooling_list_unit_2,
                tooling_list_price_2 = cost.tooling_list_price_2,
                tooling_list_amount_jpy_2 = cost.tooling_list_amount_jpy_2,
                tooling_list_amount_usd_2 = cost.tooling_list_amount_usd_2,

                tooling_list_description_3 = cost.tooling_list_description_3,
                tooling_list_type_3 = cost.tooling_list_type_3,
                tooling_list_source_3 = cost.tooling_list_source_3,
                tooling_list_qty_3 = cost.tooling_list_qty_3,
                tooling_list_unit_3 = cost.tooling_list_unit_3,
                tooling_list_price_3 = cost.tooling_list_price_3,
                tooling_list_amount_jpy_3 = cost.tooling_list_amount_jpy_3,
                tooling_list_amount_usd_3 = cost.tooling_list_amount_usd_3,

                tooling_list_description_4 = cost.tooling_list_description_4,
                tooling_list_type_4 = cost.tooling_list_type_4,
                tooling_list_source_4 = cost.tooling_list_source_4,
                tooling_list_qty_4 = cost.tooling_list_qty_4,
                tooling_list_unit_4 = cost.tooling_list_unit_4,
                tooling_list_price_4 = cost.tooling_list_price_4,
                tooling_list_amount_jpy_4 = cost.tooling_list_amount_jpy_4,
                tooling_list_amount_usd_4 = cost.tooling_list_amount_usd_4,

                tooling_list_description_5 = cost.tooling_list_description_5,
                tooling_list_type_5 = cost.tooling_list_type_5,
                tooling_list_source_5 = cost.tooling_list_source_5,
                tooling_list_qty_5 = cost.tooling_list_qty_5,
                tooling_list_unit_5 = cost.tooling_list_unit_5,
                tooling_list_price_5 = cost.tooling_list_price_5,
                tooling_list_amount_jpy_5 = cost.tooling_list_amount_jpy_5,
                tooling_list_amount_usd_5 = cost.tooling_list_amount_usd_5,

                tooling_list_description_6 = cost.tooling_list_description_6,
                tooling_list_type_6 = cost.tooling_list_type_6,
                tooling_list_source_6 = cost.tooling_list_source_6,
                tooling_list_qty_6 = cost.tooling_list_qty_6,
                tooling_list_unit_6 = cost.tooling_list_unit_6,
                tooling_list_price_6 = cost.tooling_list_price_6,
                tooling_list_amount_jpy_6 = cost.tooling_list_amount_jpy_6,
                tooling_list_amount_usd_6 = cost.tooling_list_amount_usd_6,

                tooling_list_description_7 = cost.tooling_list_description_7,
                tooling_list_type_7 = cost.tooling_list_type_7,
                tooling_list_source_7 = cost.tooling_list_source_7,
                tooling_list_qty_7 = cost.tooling_list_qty_7,
                tooling_list_unit_7 = cost.tooling_list_unit_7,
                tooling_list_price_7 = cost.tooling_list_price_7,
                tooling_list_amount_jpy_7 = cost.tooling_list_amount_jpy_7,
                tooling_list_amount_usd_7 = cost.tooling_list_amount_usd_7,

                tooling_list_description_8 = cost.tooling_list_description_8,
                tooling_list_type_8 = cost.tooling_list_type_8,
                tooling_list_source_8 = cost.tooling_list_source_8,
                tooling_list_qty_8 = cost.tooling_list_qty_8,
                tooling_list_unit_8 = cost.tooling_list_unit_8,
                tooling_list_price_8 = cost.tooling_list_price_8,
                tooling_list_amount_jpy_8 = cost.tooling_list_amount_jpy_8,
                tooling_list_amount_usd_8 = cost.tooling_list_amount_usd_8,

                tooling_list_description_9 = cost.tooling_list_description_9,
                tooling_list_type_9 = cost.tooling_list_type_9,
                tooling_list_source_9 = cost.tooling_list_source_9,
                tooling_list_qty_9 = cost.tooling_list_qty_9,
                tooling_list_unit_9 = cost.tooling_list_unit_9,
                tooling_list_price_9 = cost.tooling_list_price_9,
                tooling_list_amount_jpy_9 = cost.tooling_list_amount_jpy_9,
                tooling_list_amount_usd_9 = cost.tooling_list_amount_usd_9,

                tooling_list_description_10 = cost.tooling_list_description_10,
                tooling_list_type_10 = cost.tooling_list_type_10,
                tooling_list_source_10 = cost.tooling_list_source_10,
                tooling_list_qty_10 = cost.tooling_list_qty_10,
                tooling_list_unit_10 = cost.tooling_list_unit_10,
                tooling_list_price_10 = cost.tooling_list_price_10,
                tooling_list_amount_jpy_10 = cost.tooling_list_amount_jpy_10,
                tooling_list_amount_usd_10 = cost.tooling_list_amount_usd_10,

                tooling_list_description_11 = cost.tooling_list_description_11,
                tooling_list_type_11 = cost.tooling_list_type_11,
                tooling_list_source_11 = cost.tooling_list_source_11,
                tooling_list_qty_11 = cost.tooling_list_qty_11,
                tooling_list_unit_11 = cost.tooling_list_unit_11,
                tooling_list_price_11 = cost.tooling_list_price_11,
                tooling_list_amount_jpy_11 = cost.tooling_list_amount_jpy_11,
                tooling_list_amount_usd_11 = cost.tooling_list_amount_usd_11,

                tooling_list_description_12 = cost.tooling_list_description_12,
                tooling_list_type_12 = cost.tooling_list_type_12,
                tooling_list_source_12 = cost.tooling_list_source_12,
                tooling_list_qty_12 = cost.tooling_list_qty_12,
                tooling_list_unit_12 = cost.tooling_list_unit_12,
                tooling_list_price_12 = cost.tooling_list_price_12,
                tooling_list_amount_jpy_12 = cost.tooling_list_amount_jpy_12,
                tooling_list_amount_usd_12 = cost.tooling_list_amount_usd_12,

                tooling_list_description_13 = cost.tooling_list_description_13,
                tooling_list_type_13 = cost.tooling_list_type_13,
                tooling_list_source_13 = cost.tooling_list_source_13,
                tooling_list_qty_13 = cost.tooling_list_qty_13,
                tooling_list_unit_13 = cost.tooling_list_unit_13,
                tooling_list_price_13 = cost.tooling_list_price_13,
                tooling_list_amount_jpy_13 = cost.tooling_list_amount_jpy_13,
                tooling_list_amount_usd_13 = cost.tooling_list_amount_usd_13,

                tooling_list_description_14 = cost.tooling_list_description_14,
                tooling_list_type_14 = cost.tooling_list_type_14,
                tooling_list_source_14 = cost.tooling_list_source_14,
                tooling_list_qty_14 = cost.tooling_list_qty_14,
                tooling_list_unit_14 = cost.tooling_list_unit_14,
                tooling_list_price_14 = cost.tooling_list_price_14,
                tooling_list_amount_jpy_14 = cost.tooling_list_amount_jpy_14,
                tooling_list_amount_usd_14 = cost.tooling_list_amount_usd_14,

                tooling_list_description_15 = cost.tooling_list_description_15,
                tooling_list_type_15 = cost.tooling_list_type_15,
                tooling_list_source_15 = cost.tooling_list_source_15,
                tooling_list_qty_15 = cost.tooling_list_qty_15,
                tooling_list_unit_15 = cost.tooling_list_unit_15,
                tooling_list_price_15 = cost.tooling_list_price_15,
                tooling_list_amount_jpy_15 = cost.tooling_list_amount_jpy_15,
                tooling_list_amount_usd_15 = cost.tooling_list_amount_usd_15,

                tooling_list_total_amount_usd = cost.tooling_list_total_amount_usd,

                //process_cost = cost.cost_Processes.Select(n => n.Process.process_cost).ToList()

            }).FirstOrDefault();

            return _costWithProcess;
        }
        public Cost UpdateCostById(int costId, Cost cost)
        {
            var _cost = _context.Costs.FirstOrDefault(n => n.CostId == costId);
            //if we found the cost data then we will update the data
            if (_cost != null)
            {

                _cost.plant = cost.plant;
                _cost.item_spec = cost.item_spec;
                _cost.issue_date = cost.issue_date;
                _cost.section = cost.section;
                _cost.doc_no = cost.doc_no;
                _cost.wr_no = cost.wr_no;
                _cost.sales = cost.sales;
                _cost.revision_no = cost.revision_no;
                _cost.checked_date = cost.checked_date;
                _cost.approved_by = cost.approved_by;
                _cost.expired_by = cost.expired_by;
                _cost.customer = cost.customer;
                _cost.parts_code = cost.parts_code;
                _cost.item = cost.item;
                _cost.product = cost.product;
                _cost.product_type = cost.product_type;
                _cost.size = cost.size;
                _cost.item_id = cost.item_id;
                _cost.item_od = cost.item_od;
                _cost.item_w = cost.item_w;
                _cost.business_type = cost.business_type;
                _cost.qty_month = cost.qty_month;
                _cost.exchange_rate = cost.exchange_rate;
                _cost.target_price_bht = cost.target_price_bht;
                _cost.target_price_export = cost.target_price_export;
                _cost.production_qty_day = cost.production_qty_day;
                _cost.working_day = cost.working_day;

                _cost.rubber_material_name = cost.rubber_material_name;
                _cost.rubber_database_price_current = cost.rubber_database_price_current;
                _cost.rubber_database_price_new = cost.rubber_database_price_new;
                _cost.rubber_price_kg = cost.rubber_price_kg;
                _cost.rubber_mixing_process_cost = cost.rubber_mixing_process_cost;
                _cost.rubber_weight_g = cost.rubber_weight_g;
                _cost.rubber_weight_kg = cost.rubber_weight_kg;
                _cost.rubber_yield_rate = cost.rubber_yield_rate;
                _cost.rubber_weight_kg_yieldrate = cost.rubber_weight_kg_yieldrate;
                _cost.rubber_cost_sgd = cost.rubber_cost_sgd;
                _cost.rubber_percentage_target_price = cost.rubber_percentage_target_price;

                _cost.material_inhouse_name_1 = cost.material_inhouse_name_1;
                _cost.material_inhouse_info_1 = cost.material_inhouse_info_1;
                _cost.material_inhouse_value_1 = cost.material_inhouse_value_1;
                _cost.material_inhouse_info_1b = cost.material_inhouse_info_1b;
                _cost.material_inhouse_value_1b = cost.material_inhouse_value_1b;
                _cost.material_inhouse_cost_sgd_1 = cost.material_inhouse_cost_sgd_1;
                _cost.material_inhouse_percentage_target_price_1 = cost.material_inhouse_percentage_target_price_1;
                _cost.material_inhouse_name_2 = cost.material_inhouse_name_2;
                _cost.material_inhouse_info_2 = cost.material_inhouse_info_2;
                _cost.material_inhouse_value_2 = cost.material_inhouse_value_2;
                _cost.material_inhouse_info_2b = cost.material_inhouse_info_2b;
                _cost.material_inhouse_value_2b = cost.material_inhouse_value_2b;
                _cost.material_inhouse_cost_sgd_2 = cost.material_inhouse_cost_sgd_2;
                _cost.material_inhouse_percentage_target_price_2 = cost.material_inhouse_percentage_target_price_2;
                _cost.material_inhouse_name_3 = cost.material_inhouse_name_3;
                _cost.material_inhouse_info_3 = cost.material_inhouse_info_3;
                _cost.material_inhouse_value_3 = cost.material_inhouse_value_3;
                _cost.material_inhouse_info_3b = cost.material_inhouse_info_3b;
                _cost.material_inhouse_value_3b = cost.material_inhouse_value_3b;
                _cost.material_inhouse_cost_sgd_3 = cost.material_inhouse_cost_sgd_3;
                _cost.material_inhouse_percentage_target_price_3 = cost.material_inhouse_percentage_target_price_3;

                _cost.material_outside_name_1 = cost.material_outside_name_1;
                _cost.material_outside_info_1 = cost.material_outside_info_1;
                _cost.material_outside_value_1 = cost.material_outside_value_1;
                _cost.material_outside_info_1b = cost.material_outside_info_1b;
                _cost.material_outside_value_1b = cost.material_outside_value_1b;
                _cost.material_outside_cost_sgd_1 = cost.material_outside_cost_sgd_1;
                _cost.material_outside_percentage_target_price_1 = cost.material_outside_percentage_target_price_1;
                _cost.material_outside_name_2 = cost.material_outside_name_2;
                _cost.material_outside_info_2 = cost.material_outside_info_2;
                _cost.material_outside_value_2 = cost.material_outside_value_2;
                _cost.material_outside_info_2b = cost.material_outside_info_2b;
                _cost.material_outside_value_2b = cost.material_outside_value_2b;
                _cost.material_outside_cost_sgd_2 = cost.material_outside_cost_sgd_2;
                _cost.material_outside_percentage_target_price_2 = cost.material_outside_percentage_target_price_2;
                _cost.material_outside_name_3 = cost.material_outside_name_3;
                _cost.material_outside_info_3 = cost.material_outside_info_3;
                _cost.material_outside_value_3 = cost.material_outside_value_3;
                _cost.material_outside_info_3b = cost.material_outside_info_3b;
                _cost.material_outside_value_3b = cost.material_outside_value_3b;
                _cost.material_outside_cost_sgd_3 = cost.material_outside_cost_sgd_3;
                _cost.material_outside_percentage_target_price_3 = cost.material_outside_percentage_target_price_3;

                _cost.direct_material_cost = cost.direct_material_cost;
                _cost.direct_material_cost_percentage = cost.direct_material_cost_percentage;
                _cost.sub_material_percentage = cost.sub_material_percentage;
                _cost.sub_material_cost = cost.sub_material_cost;
                _cost.sub_material_cost_percentage = cost.sub_material_cost_percentage;
                _cost.direct_process_cost = cost.direct_process_cost;
                _cost.direct_process_cost_percentage = cost.direct_process_cost_percentage;
                _cost.total_direct_cost = cost.total_direct_cost;
                _cost.total_direct_cost_percentage = cost.total_direct_cost_percentage;
                _cost.defective_percentage = cost.defective_percentage;
                _cost.defective_cost = cost.defective_cost;
                _cost.defective_cost_percentage = cost.defective_cost_percentage;
                _cost.indirect_percentage = cost.indirect_percentage;
                _cost.indirect_cost = cost.indirect_cost;
                _cost.indirect_cost_percentage = cost.indirect_cost_percentage;
                _cost.packing_material_percentage = cost.packing_material_percentage;
                _cost.special_package_cost = cost.special_package_cost;
                _cost.packing_material_cost = cost.packing_material_cost;
                _cost.packing_material_cost_percentage = cost.packing_material_cost_percentage;
                _cost.administration_percentage = cost.administration_percentage;
                _cost.administration_cost = cost.administration_cost;
                _cost.administration_cost_percentage = cost.administration_cost_percentage;
                _cost.plant_retail_percentage = cost.plant_retail_percentage;
                _cost.plant_retail_cost = cost.plant_retail_cost;
                _cost.plant_retail_cost_percentage = cost.plant_retail_cost_percentage;
                _cost.moldjig_percentage = cost.moldjig_percentage;
                _cost.moldjig_cost = cost.moldjig_cost;
                _cost.moldjig_cost_percentage = cost.moldjig_cost_percentage;
                _cost.die_percentage = cost.die_percentage;
                _cost.die_cost = cost.die_cost;
                _cost.die_cost_percentage = cost.die_cost_percentage;
                _cost.note = cost.note;
                _cost.net_included_tooling_cost = cost.net_included_tooling_cost;
                _cost.net_included_tooling_cost_percentage = cost.net_included_tooling_cost_percentage;
                _cost.net_exclude_tooling_cost = cost.net_exclude_tooling_cost;
                _cost.net_exclude_tooling_cost_percentage = cost.net_exclude_tooling_cost_percentage;

                _cost.tooling_list_description_1 = cost.tooling_list_description_1;
                _cost.tooling_list_type_1 = cost.tooling_list_type_1;
                _cost.tooling_list_source_1 = cost.tooling_list_source_1;
                _cost.tooling_list_qty_1 = cost.tooling_list_qty_1;
                _cost.tooling_list_unit_1 = cost.tooling_list_unit_1;
                _cost.tooling_list_price_1 = cost.tooling_list_price_1;
                _cost.tooling_list_amount_jpy_1 = cost.tooling_list_amount_jpy_1;
                _cost.tooling_list_amount_usd_1 = cost.tooling_list_amount_usd_1;

                _cost.tooling_list_description_2 = cost.tooling_list_description_2;
                _cost.tooling_list_type_2 = cost.tooling_list_type_2;
                _cost.tooling_list_source_2 = cost.tooling_list_source_2;
                _cost.tooling_list_qty_2 = cost.tooling_list_qty_2;
                _cost.tooling_list_unit_2 = cost.tooling_list_unit_2;
                _cost.tooling_list_price_2 = cost.tooling_list_price_2;
                _cost.tooling_list_amount_jpy_2 = cost.tooling_list_amount_jpy_2;
                _cost.tooling_list_amount_usd_2 = cost.tooling_list_amount_usd_2;

                _cost.tooling_list_description_3 = cost.tooling_list_description_3;
                _cost.tooling_list_type_3 = cost.tooling_list_type_3;
                _cost.tooling_list_source_3 = cost.tooling_list_source_3;
                _cost.tooling_list_qty_3 = cost.tooling_list_qty_3;
                _cost.tooling_list_unit_3 = cost.tooling_list_unit_3;
                _cost.tooling_list_price_3 = cost.tooling_list_price_3;
                _cost.tooling_list_amount_jpy_3 = cost.tooling_list_amount_jpy_3;
                _cost.tooling_list_amount_usd_3 = cost.tooling_list_amount_usd_3;

                _cost.tooling_list_description_4 = cost.tooling_list_description_4;
                _cost.tooling_list_type_4 = cost.tooling_list_type_4;
                _cost.tooling_list_source_4 = cost.tooling_list_source_4;
                _cost.tooling_list_qty_4 = cost.tooling_list_qty_4;
                _cost.tooling_list_unit_4 = cost.tooling_list_unit_4;
                _cost.tooling_list_price_4 = cost.tooling_list_price_4;
                _cost.tooling_list_amount_jpy_4 = cost.tooling_list_amount_jpy_4;
                _cost.tooling_list_amount_usd_4 = cost.tooling_list_amount_usd_4;

                _cost.tooling_list_description_5 = cost.tooling_list_description_5;
                _cost.tooling_list_type_5 = cost.tooling_list_type_5;
                _cost.tooling_list_source_5 = cost.tooling_list_source_5;
                _cost.tooling_list_qty_5 = cost.tooling_list_qty_5;
                _cost.tooling_list_unit_5 = cost.tooling_list_unit_5;
                _cost.tooling_list_price_5 = cost.tooling_list_price_5;
                _cost.tooling_list_amount_jpy_5 = cost.tooling_list_amount_jpy_5;
                _cost.tooling_list_amount_usd_5 = cost.tooling_list_amount_usd_5;

                _cost.tooling_list_description_6 = cost.tooling_list_description_6;
                _cost.tooling_list_type_6 = cost.tooling_list_type_6;
                _cost.tooling_list_source_6 = cost.tooling_list_source_6;
                _cost.tooling_list_qty_6 = cost.tooling_list_qty_6;
                _cost.tooling_list_unit_6 = cost.tooling_list_unit_6;
                _cost.tooling_list_price_6 = cost.tooling_list_price_6;
                _cost.tooling_list_amount_jpy_6 = cost.tooling_list_amount_jpy_6;
                _cost.tooling_list_amount_usd_6 = cost.tooling_list_amount_usd_6;

                _cost.tooling_list_description_7 = cost.tooling_list_description_7;
                _cost.tooling_list_type_7 = cost.tooling_list_type_7;
                _cost.tooling_list_source_7 = cost.tooling_list_source_7;
                _cost.tooling_list_qty_7 = cost.tooling_list_qty_7;
                _cost.tooling_list_unit_7 = cost.tooling_list_unit_7;
                _cost.tooling_list_price_7 = cost.tooling_list_price_7;
                _cost.tooling_list_amount_jpy_7 = cost.tooling_list_amount_jpy_7;
                _cost.tooling_list_amount_usd_7 = cost.tooling_list_amount_usd_7;

                _cost.tooling_list_description_8 = cost.tooling_list_description_8;
                _cost.tooling_list_type_8 = cost.tooling_list_type_8;
                _cost.tooling_list_source_8 = cost.tooling_list_source_8;
                _cost.tooling_list_qty_8 = cost.tooling_list_qty_8;
                _cost.tooling_list_unit_8 = cost.tooling_list_unit_8;
                _cost.tooling_list_price_8 = cost.tooling_list_price_8;
                _cost.tooling_list_amount_jpy_8 = cost.tooling_list_amount_jpy_8;
                _cost.tooling_list_amount_usd_8 = cost.tooling_list_amount_usd_8;

                _cost.tooling_list_description_9 = cost.tooling_list_description_9;
                _cost.tooling_list_type_9 = cost.tooling_list_type_9;
                _cost.tooling_list_source_9 = cost.tooling_list_source_9;
                _cost.tooling_list_qty_9 = cost.tooling_list_qty_9;
                _cost.tooling_list_unit_9 = cost.tooling_list_unit_9;
                _cost.tooling_list_price_9 = cost.tooling_list_price_9;
                _cost.tooling_list_amount_jpy_9 = cost.tooling_list_amount_jpy_9;
                _cost.tooling_list_amount_usd_9 = cost.tooling_list_amount_usd_9;

                _cost.tooling_list_description_10 = cost.tooling_list_description_10;
                _cost.tooling_list_type_10 = cost.tooling_list_type_10;
                _cost.tooling_list_source_10 = cost.tooling_list_source_10;
                _cost.tooling_list_qty_10 = cost.tooling_list_qty_10;
                _cost.tooling_list_unit_10 = cost.tooling_list_unit_10;
                _cost.tooling_list_price_10 = cost.tooling_list_price_10;
                _cost.tooling_list_amount_jpy_10 = cost.tooling_list_amount_jpy_10;
                _cost.tooling_list_amount_usd_10 = cost.tooling_list_amount_usd_10;

                _cost.tooling_list_description_11 = cost.tooling_list_description_11;
                _cost.tooling_list_type_11 = cost.tooling_list_type_11;
                _cost.tooling_list_source_11 = cost.tooling_list_source_11;
                _cost.tooling_list_qty_11 = cost.tooling_list_qty_11;
                _cost.tooling_list_unit_11 = cost.tooling_list_unit_11;
                _cost.tooling_list_price_11 = cost.tooling_list_price_11;
                _cost.tooling_list_amount_jpy_11 = cost.tooling_list_amount_jpy_11;
                _cost.tooling_list_amount_usd_11 = cost.tooling_list_amount_usd_11;

                _cost.tooling_list_description_12 = cost.tooling_list_description_12;
                _cost.tooling_list_type_12 = cost.tooling_list_type_12;
                _cost.tooling_list_source_12 = cost.tooling_list_source_12;
                _cost.tooling_list_qty_12 = cost.tooling_list_qty_12;
                _cost.tooling_list_unit_12 = cost.tooling_list_unit_12;
                _cost.tooling_list_price_12 = cost.tooling_list_price_12;
                _cost.tooling_list_amount_jpy_12 = cost.tooling_list_amount_jpy_12;
                _cost.tooling_list_amount_usd_12 = cost.tooling_list_amount_usd_12;

                _cost.tooling_list_description_13 = cost.tooling_list_description_13;
                _cost.tooling_list_type_13 = cost.tooling_list_type_13;
                _cost.tooling_list_source_13 = cost.tooling_list_source_13;
                _cost.tooling_list_qty_13 = cost.tooling_list_qty_13;
                _cost.tooling_list_unit_13 = cost.tooling_list_unit_13;
                _cost.tooling_list_price_13 = cost.tooling_list_price_13;
                _cost.tooling_list_amount_jpy_13 = cost.tooling_list_amount_jpy_13;
                _cost.tooling_list_amount_usd_13 = cost.tooling_list_amount_usd_13;

                _cost.tooling_list_description_14 = cost.tooling_list_description_14;
                _cost.tooling_list_type_14 = cost.tooling_list_type_14;
                _cost.tooling_list_source_14 = cost.tooling_list_source_14;
                _cost.tooling_list_qty_14 = cost.tooling_list_qty_14;
                _cost.tooling_list_unit_14 = cost.tooling_list_unit_14;
                _cost.tooling_list_price_14 = cost.tooling_list_price_14;
                _cost.tooling_list_amount_jpy_14 = cost.tooling_list_amount_jpy_14;
                _cost.tooling_list_amount_usd_14 = cost.tooling_list_amount_usd_14;

                _cost.tooling_list_description_15 = cost.tooling_list_description_15;
                _cost.tooling_list_type_15 = cost.tooling_list_type_15;
                _cost.tooling_list_source_15 = cost.tooling_list_source_15;
                _cost.tooling_list_qty_15 = cost.tooling_list_qty_15;
                _cost.tooling_list_unit_15 = cost.tooling_list_unit_15;
                _cost.tooling_list_price_15 = cost.tooling_list_price_15;
                _cost.tooling_list_amount_jpy_15 = cost.tooling_list_amount_jpy_15;
                _cost.tooling_list_amount_usd_15 = cost.tooling_list_amount_usd_15;

                _cost.tooling_list_total_amount_usd = cost.tooling_list_total_amount_usd;

                _context.SaveChanges();
            }
            return _cost;
        }

        public void DeleteCostById(int costId)
        {
            var _cost = _context.Costs.FirstOrDefault(n => n.CostId == costId);
            //if we found the cost data then we will update the data
            if (_cost != null)
            {
                _context.Costs.Remove(_cost);
                _context.SaveChanges();
            }

        }

    }
}











