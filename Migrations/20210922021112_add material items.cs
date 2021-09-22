using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class addmaterialitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "material_inhouse_info_1b",
                table: "Costs",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_inhouse_info_2b",
                table: "Costs",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_inhouse_info_3b",
                table: "Costs",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "material_inhouse_value_1",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_inhouse_value_1b",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_inhouse_value_2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_inhouse_value_2b",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_inhouse_value_3",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_inhouse_value_3b",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "material_outside_info_1b",
                table: "Costs",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_outside_info_2b",
                table: "Costs",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "material_outside_info_3b",
                table: "Costs",
                type: "character varying(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "material_outside_value_1",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_outside_value_1b",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_outside_value_2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_outside_value_2b",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_outside_value_3",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "material_outside_value_3b",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "material_inhouse_info_1b",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_info_2b",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_info_3b",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_value_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_value_1b",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_value_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_value_2b",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_value_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_inhouse_value_3b",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_info_1b",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_info_2b",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_info_3b",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_value_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_value_1b",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_value_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_value_2b",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_value_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "material_outside_value_3b",
                table: "Costs");
        }
    }
}
