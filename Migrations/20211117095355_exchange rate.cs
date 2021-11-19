using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class exchangerate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "exchange_rate_eud",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "exchange_rate_jpy",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "exchange_rate_usd",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "exchange_rate_eud",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "exchange_rate_jpy",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "exchange_rate_usd",
                table: "Costs");
        }
    }
}
