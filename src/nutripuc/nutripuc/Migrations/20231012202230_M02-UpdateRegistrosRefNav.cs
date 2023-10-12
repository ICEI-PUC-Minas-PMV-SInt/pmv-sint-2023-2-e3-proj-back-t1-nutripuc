using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nutripuc.Migrations
{
    public partial class M02UpdateRegistrosRefNav : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AlimentacaoId",
                table: "Registros",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AtividadeFisicaId",
                table: "Registros",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Registros_AlimentacaoId",
                table: "Registros",
                column: "AlimentacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_AtividadeFisicaId",
                table: "Registros",
                column: "AtividadeFisicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registros_Alimentacao_AlimentacaoId",
                table: "Registros",
                column: "AlimentacaoId",
                principalTable: "Alimentacao",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Registros_AtividadeFisica_AtividadeFisicaId",
                table: "Registros",
                column: "AtividadeFisicaId",
                principalTable: "AtividadeFisica",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registros_Alimentacao_AlimentacaoId",
                table: "Registros");

            migrationBuilder.DropForeignKey(
                name: "FK_Registros_AtividadeFisica_AtividadeFisicaId",
                table: "Registros");

            migrationBuilder.DropIndex(
                name: "IX_Registros_AlimentacaoId",
                table: "Registros");

            migrationBuilder.DropIndex(
                name: "IX_Registros_AtividadeFisicaId",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "AlimentacaoId",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "AtividadeFisicaId",
                table: "Registros");
        }
    }
}
