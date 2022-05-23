using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TaxiOrmApi.Migrations
{
    public partial class MotoristaEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "motorista",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character(60)", fixedLength: true, maxLength: 60, nullable: false),
                    cpf = table.Column<string>(type: "character(11)", fixedLength: true, maxLength: 11, nullable: false),
                    numero_cnh = table.Column<string>(type: "character(11)", fixedLength: true, maxLength: 11, nullable: false),
                    veiculo_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_motorista", x => x.id);
                    table.ForeignKey(
                        name: "fk_motorista_veiculo_veiculo_id",
                        column: x => x.veiculo_id,
                        principalTable: "veiculo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_motorista_cpf",
                table: "motorista",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_motorista_numero_cnh",
                table: "motorista",
                column: "numero_cnh",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_motorista_veiculo_id",
                table: "motorista",
                column: "veiculo_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "motorista");
        }
    }
}
