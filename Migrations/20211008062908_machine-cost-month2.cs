using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class machinecostmonth2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "machine_cost_month2",
                table: "Processes",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "machine_cost_month2",
                table: "Processes");
        }
    }
}
