using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TaxiOrmApi.Migrations
{
    public partial class SolicitacaoEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "solicitacao",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data_hora = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    cliente_id = table.Column<int>(type: "integer", nullable: false),
                    motorista_id = table.Column<int>(type: "integer", nullable: false),
                    localizacao_origem_id = table.Column<int>(type: "integer", nullable: false),
                    localizacao_destino_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_solicitacao", x => x.id);
                    table.ForeignKey(
                        name: "fk_solicitacao_cliente_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_solicitacao_localizacao_localizacao_destino_id",
                        column: x => x.localizacao_destino_id,
                        principalTable: "localizacao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_solicitacao_localizacao_localizacao_origem_id",
                        column: x => x.localizacao_origem_id,
                        principalTable: "localizacao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_solicitacao_motorista_motorista_id",
                        column: x => x.motorista_id,
                        principalTable: "motorista",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_solicitacao_cliente_id",
                table: "solicitacao",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "ix_solicitacao_localizacao_destino_id",
                table: "solicitacao",
                column: "localizacao_destino_id");

            migrationBuilder.CreateIndex(
                name: "ix_solicitacao_localizacao_origem_id",
                table: "solicitacao",
                column: "localizacao_origem_id");

            migrationBuilder.CreateIndex(
                name: "ix_solicitacao_motorista_id",
                table: "solicitacao",
                column: "motorista_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "solicitacao");
        }
    }
}
