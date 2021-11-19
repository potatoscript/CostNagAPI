using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class additionalfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "item_w2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_cost_sgd2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_database_price_current2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_database_price_new2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "rubber_material_name2",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "rubber_mixing_process_cost2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_percentage_target_price2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_price_kg2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_weight_g2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_weight_kg2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_weight_kg_yieldrate2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_yield_rate2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "target_price_eud",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "target_price_sgd",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "target_price_usd",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "target_price_wr_eud",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "target_price_wr_sgd",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "target_price_wr_usd",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "item_w2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_cost_sgd2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_database_price_current2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_database_price_new2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_material_name2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_mixing_process_cost2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_percentage_target_price2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_price_kg2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_weight_g2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_weight_kg2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_weight_kg_yieldrate2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "rubber_yield_rate2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "target_price_eud",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "target_price_sgd",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "target_price_usd",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "target_price_wr_eud",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "target_price_wr_sgd",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "target_price_wr_usd",
                table: "Costs");
        }
    }
}
