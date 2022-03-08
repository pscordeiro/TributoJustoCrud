using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudTributoJusto.Data.Migrations
{
    public partial class RemoveEndFornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Fornecedores_FornecedorId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_FornecedorId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Enderecos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FornecedorId",
                table: "Enderecos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_FornecedorId",
                table: "Enderecos",
                column: "FornecedorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Fornecedores_FornecedorId",
                table: "Enderecos",
                column: "FornecedorId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
