using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudTributoJusto.Data.Migrations
{
    public partial class AddPedido2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoId",
                table: "Pedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ProdutoId",
                table: "Pedido",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Produtos_ProdutoId",
                table: "Pedido",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Produtos_ProdutoId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_ProdutoId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Pedido");
        }
    }
}
