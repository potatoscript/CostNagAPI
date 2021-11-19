using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class exchangerate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "exchange_rate",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "target_price_bht",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "target_price_export",
                table: "Costs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "exchange_rate",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "target_price_bht",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "target_price_export",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
