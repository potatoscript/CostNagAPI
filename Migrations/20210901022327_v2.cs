using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "approved_by",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "business_type",
                table: "Costs",
                type: "character varying(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "checked_date",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "customer",
                table: "Costs",
                type: "character varying(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "doc_no",
                table: "Costs",
                type: "character varying(20)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "exchange_rate",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "item",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "parts_code",
                table: "Costs",
                type: "character varying(15)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "product",
                table: "Costs",
                type: "character varying(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "product_type",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "production_qty_day",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "qty_month",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "revision_no",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sales",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "size",
                table: "Costs",
                type: "character varying(10)",
                nullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "working_day",
                table: "Costs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "wr_no",
                table: "Costs",
                type: "character varying(20)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "approved_by",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "business_type",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "checked_date",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "customer",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "doc_no",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "exchange_rate",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "item",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "parts_code",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "product",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "product_type",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "production_qty_day",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "qty_month",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "revision_no",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "sales",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "size",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "target_price_bht",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "target_price_export",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "working_day",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "wr_no",
                table: "Costs");
        }
    }
}
