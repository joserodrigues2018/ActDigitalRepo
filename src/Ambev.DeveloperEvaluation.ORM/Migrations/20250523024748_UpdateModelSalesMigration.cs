using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelSalesMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SaleOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CartId = table.Column<Guid>(type: "uuid", nullable: false),
                    NumeroVenda = table.Column<int>(type: "integer", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Client = table.Column<string>(type: "text", nullable: true),
                    ValueTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    Filial = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SaleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    ValueTotIten = table.Column<decimal>(type: "numeric", nullable: false),
                    PercentDiscount = table.Column<int>(type: "integer", nullable: false),
                    SaleOrderId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleOrderItems_SaleOrders_SaleOrderId",
                        column: x => x.SaleOrderId,
                        principalTable: "SaleOrders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderItems_SaleOrderId",
                table: "SaleOrderItems",
                column: "SaleOrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleOrderItems");

            migrationBuilder.DropTable(
                name: "SaleOrders");
        }
    }
}
