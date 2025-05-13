using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConfigurationsCartMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItens_Products_ProductCartNavId",
                table: "CartItens");

            migrationBuilder.DropIndex(
                name: "IX_CartItens_ProductCartNavId",
                table: "CartItens");

            migrationBuilder.DropColumn(
                name: "ProductCartNavId",
                table: "CartItens");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductCartNavId",
                table: "CartItens",
                type: "uuid",
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
    }
}
