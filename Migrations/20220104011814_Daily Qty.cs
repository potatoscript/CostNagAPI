using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class DailyQty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "actual_working_time",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "cycle_time",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "daily_amount",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "daily_qty_days",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "daily_qty_days_p",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "efficiency",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "production_capacity",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "actual_working_time",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "cycle_time",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "daily_amount",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "daily_qty_days",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "daily_qty_days_p",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "efficiency",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "production_capacity",
                table: "Costs");
        }
    }
}
