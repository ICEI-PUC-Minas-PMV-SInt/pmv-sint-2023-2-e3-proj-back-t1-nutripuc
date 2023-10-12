using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nutripuc.Migrations
{
    public partial class M01AppModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataDoRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UrlDaImagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registros_Usuarios_IdDoUsuario",
                        column: x => x.IdDoUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alimentacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoDeRefeicao = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefeicaoDoLixo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alimentacao_Registros_Id",
                        column: x => x.Id,
                        principalTable: "Registros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AtividadeFisica",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloDaAtividade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaDaAtividade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Intensidade = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadeFisica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtividadeFisica_Registros_Id",
                        column: x => x.Id,
                        principalTable: "Registros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registros_IdDoUsuario",
                table: "Registros",
                column: "IdDoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alimentacao");

            migrationBuilder.DropTable(
                name: "AtividadeFisica");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
