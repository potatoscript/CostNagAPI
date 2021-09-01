using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CostNAGAPI.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Costs",
                columns: table => new
                {
                    CostId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    plant = table.Column<string>(type: "character varying(5)", nullable: true),
                    item_spec = table.Column<string>(type: "character varying(20)", nullable: true),
                    issue_date = table.Column<string>(type: "character varying(10)", nullable: true),
                    section = table.Column<string>(type: "character varying(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costs", x => x.CostId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Costs");
        }
    }
}
