using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CostNAGAPI.Migrations
{
    public partial class rubber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rubbers",
                columns: table => new
                {
                    RubberId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    material_name = table.Column<string>(type: "character varying(10)", nullable: true),
                    price_kg = table.Column<double>(type: "double precision", nullable: false),
                    mixing_process_cost = table.Column<double>(type: "double precision", nullable: false),
                    weight_g = table.Column<double>(type: "double precision", nullable: false),
                    weight_kg = table.Column<double>(type: "double precision", nullable: false),
                    yield_rate = table.Column<double>(type: "double precision", nullable: false),
                    weight_kg_pcs = table.Column<double>(type: "double precision", nullable: false),
                    rubber_sgd = table.Column<double>(type: "double precision", nullable: false),
                    rubber_target_price_percentage = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubbers", x => x.RubberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rubbers");
        }
    }
}
