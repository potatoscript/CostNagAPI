using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CostNAGAPI.Migrations
{
    public partial class costProcess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costs_Processes");

            migrationBuilder.CreateTable(
                name: "CostsProcesses",
                columns: table => new
                {
                    CostProcessId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    doc_no = table.Column<string>(type: "character varying(20)", nullable: true),
                    process_name = table.Column<string>(type: "character varying(100)", nullable: true),
                    process_type = table.Column<string>(type: "character varying(20)", nullable: true),
                    od_min = table.Column<double>(type: "double precision", nullable: false),
                    od_max = table.Column<double>(type: "double precision", nullable: false),
                    overhead_cost = table.Column<double>(type: "double precision", nullable: false),
                    machine_cost = table.Column<double>(type: "double precision", nullable: false),
                    labor_cost = table.Column<double>(type: "double precision", nullable: false),
                    total_cost = table.Column<double>(type: "double precision", nullable: false),
                    CostId = table.Column<int>(type: "integer", nullable: true),
                    ProcessId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostsProcesses", x => x.CostProcessId);
                    table.ForeignKey(
                        name: "FK_CostsProcesses_Costs_CostId",
                        column: x => x.CostId,
                        principalTable: "Costs",
                        principalColumn: "CostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CostsProcesses_Processes_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Processes",
                        principalColumn: "ProcessId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CostsProcesses_CostId",
                table: "CostsProcesses",
                column: "CostId");

            migrationBuilder.CreateIndex(
                name: "IX_CostsProcesses_ProcessId",
                table: "CostsProcesses",
                column: "ProcessId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostsProcesses");

            migrationBuilder.CreateTable(
                name: "Costs_Processes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CostId = table.Column<int>(type: "integer", nullable: false),
                    ProcessId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs_Processes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Costs_Processes_Costs_CostId",
                        column: x => x.CostId,
                        principalTable: "Costs",
                        principalColumn: "CostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Costs_Processes_Processes_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Processes",
                        principalColumn: "ProcessId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Costs_Processes_CostId",
                table: "Costs_Processes",
                column: "CostId");

            migrationBuilder.CreateIndex(
                name: "IX_Costs_Processes_ProcessId",
                table: "Costs_Processes",
                column: "ProcessId");
        }
    }
}
