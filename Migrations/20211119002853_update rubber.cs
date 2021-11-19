using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class updaterubber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rubber_sgd",
                table: "Rubbers");

            migrationBuilder.DropColumn(
                name: "rubber_target_price_percentage",
                table: "Rubbers");

            migrationBuilder.DropColumn(
                name: "weight_kg",
                table: "Rubbers");

            migrationBuilder.DropColumn(
                name: "weight_kg_pcs",
                table: "Rubbers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "rubber_sgd",
                table: "Rubbers",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "rubber_target_price_percentage",
                table: "Rubbers",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "weight_kg",
                table: "Rubbers",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "weight_kg_pcs",
                table: "Rubbers",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
