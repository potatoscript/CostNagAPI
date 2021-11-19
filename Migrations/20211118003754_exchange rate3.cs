using Microsoft.EntityFrameworkCore.Migrations;

namespace CostNAGAPI.Migrations
{
    public partial class exchangerate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_1",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_10",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_11",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_12",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_13",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_14",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_15",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_2",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_3",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_4",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_5",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_6",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_7",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_8",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_amount_sgd_9",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tooling_list_total_amount_sgd",
                table: "Costs",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_1",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_10",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_11",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_12",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_13",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_14",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_15",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_2",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_3",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_4",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_5",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_6",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_7",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_8",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_amount_sgd_9",
                table: "Costs");

            migrationBuilder.DropColumn(
                name: "tooling_list_total_amount_sgd",
                table: "Costs");
        }
    }
}
