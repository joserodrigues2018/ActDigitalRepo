using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class NewModelsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    DateRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(5,2)", precision: 5, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("053fe689-6338-4888-838f-f2d6e380320c"), "Alimentos", "farrinha", "Image1", 10.90m, "Produto Teste5" },
                    { new Guid("0550fb96-50e5-4968-acc3-0af01870a18d"), "Alimentos", "Leite em liquido", "Image1", 150.03m, "Produto Teste12" },
                    { new Guid("0773a99f-40d2-4c24-8aaf-7d45e42ab856"), "Alimentos", "Leite em liquido", "Image1", 4.50m, "Produto Teste19" },
                    { new Guid("234da59d-1e6c-426a-b63f-ca25991fadbb"), "Alimentos", "macarrao", "Image1", 11.30m, "Produto Teste6" },
                    { new Guid("50d5ceb1-a8a4-4f3a-beb5-5c5da018635b"), "Alimentos", "doce de leite", "Image1", 20.50m, "Produto Teste8" },
                    { new Guid("57ac8ad9-7c66-42db-aae7-ede32745aeb4"), "Alimentos", "Leite em liquido", "Image1", 55.76m, "Produto Teste14" },
                    { new Guid("6105ddfe-636a-40b2-b3ec-77b695d2a528"), "Alimentos", "Leite em liquido", "Image1", 7.50m, "Produto Teste22" },
                    { new Guid("6889f9b5-e741-4356-a803-b9937cb3f431"), "Alimentos", "Leite em liquido", "Image1", 22.50m, "Produto Teste10" },
                    { new Guid("6e94c72e-6c44-4068-a3ed-5868ad28f5bf"), "Alimentos", "Leite em liquido", "Image1", 0.50m, "Produto Teste25" },
                    { new Guid("7085290f-4c94-41b6-a26b-6942043b8284"), "Alimentos", "Leite em liquido", "Image1", 21.50m, "Produto Teste9" },
                    { new Guid("74a0cc42-a507-4af2-abd7-a6bd60dc601c"), "Alimentos", "Leite em liquido", "Image1", 48.76m, "Produto Teste13" },
                    { new Guid("837c5d3a-537e-41e4-a1fc-205fe0800ed3"), "Alimentos", "Leite em liquido", "Image1", 100.51m, "Produto Teste16" },
                    { new Guid("8c49293a-cb5d-4d5e-b974-b684d760e68b"), "Alimentos", "batata doce", "Image1", 20.5m, "Produto Teste2" },
                    { new Guid("9023a0cd-6ac3-497f-be5e-6d528f7a9447"), "Alimentos", "Leite em liquido", "Image1", 40.00m, "Produto Teste15" },
                    { new Guid("99e3da6e-a480-4f5f-8058-03f4a6840e88"), "Alimentos", "tomnate", "Image1", 2.50m, "Produto Teste3" },
                    { new Guid("9f0f5a2f-6cca-459d-ad4e-133402183019"), "Alimentos", "Leite em liquido", "Image1", 8.50m, "Produto Teste23" },
                    { new Guid("a0c0949c-c7fa-401f-8fcf-4874906bbd0b"), "Alimentos", "Leite em liquido", "Image1", 6.50m, "Produto Teste21" },
                    { new Guid("aa7955f3-6849-479a-810f-5009a44e7ffd"), "Alimentos", "Leite em liquido", "Image1", 23.75m, "Produto Teste11" },
                    { new Guid("b6ab9232-1fe8-40d3-9d5d-828b11041a2a"), "Alimentos", "Leite em liquido", "Image1", 200.47m, "Produto Teste17" },
                    { new Guid("b7301b08-10a7-4f88-b4ae-639bddf522cd"), "Alimentos", "Leite em liquido", "Image1", 9.50m, "Produto Teste24" },
                    { new Guid("c88ed001-4713-43e2-ab26-5afb06866daa"), "Alimentos", "Leite em liquido", "Image1", 3.50m, "Produto Teste18" },
                    { new Guid("dc141325-4397-4608-a3f5-e2d99fbeea2b"), "Alimentos", "Leite em liquido", "Image1", 5.50m, "Produto Teste20" },
                    { new Guid("e08e8a39-a99f-44b8-9d02-7204edc46b20"), "Alimentos", "conserva", "Image1", 12.70m, "Produto Teste7" },
                    { new Guid("f6b69aa6-e2f3-43f6-a05e-bd2197665248"), "Alimentos", "Leite em liquido", "Image1", 1.50m, "Produto Teste1" },
                    { new Guid("fb461642-0ab9-4c35-b267-db7245389144"), "Alimentos", "cebola", "Image1", 3.59m, "Produto Teste4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
