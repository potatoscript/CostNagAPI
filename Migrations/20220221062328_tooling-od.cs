using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class toolingod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "od",
                table: "Toolings",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "od",
                table: "Toolings");
        }
    }
}
