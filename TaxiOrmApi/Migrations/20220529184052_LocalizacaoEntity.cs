using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TaxiOrmApi.Migrations
{
    public partial class LocalizacaoEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "localizacao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cep = table.Column<string>(type: "character(11)", fixedLength: true, maxLength: 11, nullable: true),
                    uf = table.Column<string>(type: "character(2)", fixedLength: true, maxLength: 2, nullable: false),
                    cidade = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    bairro = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    logradouro = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    numero = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: true),
                    complemento = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_localizacao", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "localizacao");
        }
    }
}
