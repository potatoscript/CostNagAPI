using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class v3toolinglist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_1",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_10",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_11",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_12",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_13",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_14",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_15",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_3",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_4",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_5",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_6",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_7",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_8",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_jpy_9",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_1",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_10",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_11",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_12",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_13",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_14",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_15",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_3",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_4",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_5",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_6",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_7",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_8",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_usd_9",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_1",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_10",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_11",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_12",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_13",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_14",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_15",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_2",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_3",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_4",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_5",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_6",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_7",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_8",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_description_9",
                table: "Costs",
                type: "character varying(50)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_1",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_10",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_11",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_12",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_13",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_14",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_15",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_3",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_4",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_5",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_6",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_7",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_8",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_price_9",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_1",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_10",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_11",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_12",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_13",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_14",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_15",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_2",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_3",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_4",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_5",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_6",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_7",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_8",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tooling_list_qty_9",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_1",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_10",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_11",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_12",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_13",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_14",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_15",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_2",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_3",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_4",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_5",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_6",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_7",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_8",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_source_9",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_total_amount_usd",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_1",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_10",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_11",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_12",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_13",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_14",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_15",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_2",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_3",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_4",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_5",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_6",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_7",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_8",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_type_9",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_1",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_10",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_11",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_12",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_13",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_14",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_15",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_2",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_3",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_4",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_5",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_6",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_7",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_8",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tooling_list_unit_9",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_10",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_11",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_12",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_13",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_14",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_15",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_4",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_5",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_6",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_7",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_8",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_jpy_9",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_10",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_11",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_12",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_13",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_14",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_15",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_4",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_5",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_6",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_7",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_8",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_usd_9",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_10",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_11",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_12",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_13",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_14",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_15",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_4",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_5",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_6",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_7",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_8",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_description_9",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_10",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_11",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_12",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_13",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_14",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_15",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_4",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_5",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_6",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_7",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_8",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_price_9",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_10",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_11",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_12",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_13",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_14",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_15",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_4",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_5",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_6",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_7",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_8",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_qty_9",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_10",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_11",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_12",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_13",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_14",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_15",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_4",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_5",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_6",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_7",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_8",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_source_9",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_total_amount_usd",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_10",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_11",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_12",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_13",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_14",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_15",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_4",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_5",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_6",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_7",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_8",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_type_9",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_10",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_11",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_12",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_13",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_14",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_15",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_4",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_5",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_6",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_7",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_8",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_unit_9",
                table: "Costs");
        }
    }
}
