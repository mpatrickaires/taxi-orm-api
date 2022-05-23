using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TaxiOrmApi.Migrations
{
    public partial class VeiculoEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "veiculo",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    modelo_id = table.Column<int>(type: "integer", nullable: false),
                    renavam = table.Column<string>(type: "character(11)", fixedLength: true, maxLength: 11, nullable: false),
                    ano = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_veiculo", x => x.id);
                    table.ForeignKey(
                        name: "fk_veiculo_modelo_modelo_id",
                        column: x => x.modelo_id,
                        principalTable: "modelo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_veiculo_modelo_id",
                table: "veiculo",
                column: "modelo_id");

            migrationBuilder.CreateIndex(
                name: "ix_veiculo_renavam",
                table: "veiculo",
                column: "renavam",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "veiculo");
        }
    }
}
