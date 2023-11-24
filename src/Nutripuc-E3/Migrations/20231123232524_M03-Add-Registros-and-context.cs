using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nutripuc_E3.Migrations
{
    public partial class M03AddRegistrosandcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Alimentacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoDeRefeicao = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefeicaoDoLixo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AtividadeFisica",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloDoRegistro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaDaAtividade = table.Column<int>(type: "int", nullable: false),
                    Intensidade = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadeFisica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataDoRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdDoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AtividadeFisicaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AlimentacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registros_Alimentacao_AlimentacaoId",
                        column: x => x.AlimentacaoId,
                        principalTable: "Alimentacao",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Registros_AtividadeFisica_AtividadeFisicaId",
                        column: x => x.AtividadeFisicaId,
                        principalTable: "AtividadeFisica",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Registros_Usuarios_IdDoUsuario",
                        column: x => x.IdDoUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Registros_AlimentacaoId",
                table: "Registros",
                column: "AlimentacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_AtividadeFisicaId",
                table: "Registros",
                column: "AtividadeFisicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_IdDoUsuario",
                table: "Registros",
                column: "IdDoUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Alimentacao_Registros_Id",
                table: "Alimentacao",
                column: "Id",
                principalTable: "Registros",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AtividadeFisica_Registros_Id",
                table: "AtividadeFisica",
                column: "Id",
                principalTable: "Registros",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alimentacao_Registros_Id",
                table: "Alimentacao");

            migrationBuilder.DropForeignKey(
                name: "FK_AtividadeFisica_Registros_Id",
                table: "AtividadeFisica");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Alimentacao");

            migrationBuilder.DropTable(
                name: "AtividadeFisica");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
