using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class v2calculation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "administration_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "administration_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "administration_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "defective_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "defective_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "defective_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "die_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "die_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "die_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "direct_material_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "direct_material_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "direct_process_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "direct_process_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "indirect_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "indirect_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "indirect_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_inhouse_cost_sgd_1",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_inhouse_cost_sgd_2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_inhouse_cost_sgd_3",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "material_inhouse_info_1",
                table: "Costs",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_inhouse_info_2",
                table: "Costs",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_inhouse_info_3",
                table: "Costs",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_inhouse_name_1",
                table: "Costs",
                type: "character varying(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_inhouse_name_2",
                table: "Costs",
                type: "character varying(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_inhouse_name_3",
                table: "Costs",
                type: "character varying(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "material_inhouse_percentage_target_price_1",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_inhouse_percentage_target_price_2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_inhouse_percentage_target_price_3",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_outside_cost_sgd_1",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_outside_cost_sgd_2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_outside_cost_sgd_3",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "material_outside_info_1",
                table: "Costs",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_outside_info_2",
                table: "Costs",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_outside_info_3",
                table: "Costs",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_outside_name_1",
                table: "Costs",
                type: "character varying(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_outside_name_2",
                table: "Costs",
                type: "character varying(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_outside_name_3",
                table: "Costs",
                type: "character varying(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "material_outside_percentage_target_price_1",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_outside_percentage_target_price_2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_outside_percentage_target_price_3",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "moldjig_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "moldjig_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "moldjig_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "net_exclude_tooling_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "net_exclude_tooling_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "net_included_tooling_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "net_included_tooling_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "note",
                table: "Costs",
                type: "character varying(200)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "packing_material_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "packing_material_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "packing_material_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "plant_retail_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "plant_retail_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "plant_retail_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_cost_sgd",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_database_price_current",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_database_price_new",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "rubber_material_name",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "rubber_mixing_process_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_percentage_target_price",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_price_kg",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_weight_g",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_weight_kg",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_weight_kg_yieldrate",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_yield_rate",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "sub_material_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "sub_material_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "sub_material_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "total_direct_cost",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "total_direct_cost_percentage",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "administration_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "administration_cost_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "administration_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "defective_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "defective_cost_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "defective_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "die_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "die_cost_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "die_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "direct_material_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "direct_material_cost_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "direct_process_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "direct_process_cost_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "indirect_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "indirect_cost_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "indirect_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_cost_sgd_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_cost_sgd_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_cost_sgd_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_info_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_info_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_info_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_name_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_name_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_name_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_percentage_target_price_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_percentage_target_price_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_percentage_target_price_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_cost_sgd_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_cost_sgd_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_cost_sgd_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_info_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_info_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_info_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_name_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_name_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_name_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_percentage_target_price_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_percentage_target_price_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_percentage_target_price_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "moldjig_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "moldjig_cost_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "moldjig_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "net_exclude_tooling_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "net_exclude_tooling_cost_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "net_included_tooling_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "net_included_tooling_cost_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "note",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "packing_material_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "packing_material_cost_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "packing_material_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "plant_retail_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "plant_retail_cost_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "plant_retail_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_cost_sgd",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_database_price_current",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_database_price_new",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_material_name",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_mixing_process_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_percentage_target_price",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_price_kg",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_weight_g",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_weight_kg",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_weight_kg_yieldrate",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_yield_rate",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "sub_material_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "sub_material_cost_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "sub_material_percentage",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "total_direct_cost",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "total_direct_cost_percentage",
                table: "Costs");
        }
    }
}
