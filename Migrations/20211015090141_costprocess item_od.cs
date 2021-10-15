using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class costprocessitem_od : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "od_max",
                table: "CostsProcesses");

            migrationBuilder.RenameColumn(
                name: "od_min",
                table: "CostsProcesses",
                newName: "item_od");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "item_od",
                table: "CostsProcesses",
                newName: "od_min");

            migrationBuilder.AddColumn<double>(
                name: "od_max",
                table: "CostsProcesses",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
