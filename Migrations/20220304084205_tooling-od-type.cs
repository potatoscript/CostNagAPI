using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class toolingodtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "od_max",
                table: "Toolings",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Toolings",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "rubber_material_name2",
                table: "Costs",
                type: "character varying(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "rubber_material_name",
                table: "Costs",
                type: "character varying(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "od_max",
                table: "Toolings");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Toolings");

            migrationBuilder.AlterColumn<string>(
                name: "rubber_material_name2",
                table: "Costs",
                type: "character varying(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "rubber_material_name",
                table: "Costs",
                type: "character varying(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldNullable: true);
        }
    }
}
