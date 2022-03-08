using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudTributoJusto.Data.Migrations
{
    public partial class Clientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Clientes_ClienteId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pedido_PedidoId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Clientes");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteId",
                table: "Pedido",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Pedido",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Clientes_ClienteId",
                table: "Pedido",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pedido_PedidoId",
                table: "Produtos",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Clientes_ClienteId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pedido_PedidoId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Pedido");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteId",
                table: "Pedido",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "PedidoId",
                table: "Pedido",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Clientes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pedido",
                table: "Pedido",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Clientes_ClienteId",
                table: "Pedido",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pedido_PedidoId",
                table: "Produtos",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "PedidoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
