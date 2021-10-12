using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CostNAGAPI.Migrations
{
    public partial class processmaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "process_name",
                table: "Processes",
                type: "character varying(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProcessesMaster",
                columns: table => new
                {
                    ProcessMasterId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    process_name = table.Column<string>(type: "character varying(100)", nullable: true),
                    od_min = table.Column<double>(type: "double precision", nullable: false),
                    od_max = table.Column<double>(type: "double precision", nullable: false),
                    overhead_cost = table.Column<double>(type: "double precision", nullable: false),
                    machine_cost = table.Column<double>(type: "double precision", nullable: false),
                    labor_cost = table.Column<double>(type: "double precision", nullable: false),
                    total_cost = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessesMaster", x => x.ProcessMasterId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcessesMaster");

            migrationBuilder.AlterColumn<string>(
                name: "process_name",
                table: "Processes",
                type: "character varying(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldNullable: true);
        }
    }
}
