using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateRegistro",
                table: "Carts",
                newName: "CartDate");

            migrationBuilder.AddColumn<string>(
                name: "Client",
                table: "Carts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Filial",
                table: "Carts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusCart",
                table: "Carts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ValueTotal",
                table: "Carts",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "CartItens",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductCartNavId",
                table: "CartItens",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusIten",
                table: "CartItens",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "CartItens",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ValueTotIten",
                table: "CartItens",
                type: "numeric",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItens_ProductCartNavId",
                table: "CartItens",
                column: "ProductCartNavId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItens_Products_ProductCartNavId",
                table: "CartItens",
                column: "ProductCartNavId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItens_Products_ProductCartNavId",
                table: "CartItens");

            migrationBuilder.DropIndex(
                name: "IX_CartItens_ProductCartNavId",
                table: "CartItens");

            migrationBuilder.DropColumn(
                name: "Client",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Filial",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "StatusCart",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "ValueTotal",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "CartItens");

            migrationBuilder.DropColumn(
                name: "ProductCartNavId",
                table: "CartItens");

            migrationBuilder.DropColumn(
                name: "StatusIten",
                table: "CartItens");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "CartItens");

            migrationBuilder.DropColumn(
                name: "ValueTotIten",
                table: "CartItens");

            migrationBuilder.RenameColumn(
                name: "CartDate",
                table: "Carts",
                newName: "DateRegistro");
        }
    }
}
