using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class ProductConfiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(u => u.Title).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Price).IsRequired().HasPrecision(5, 2);
            builder.Property(u => u.Description).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Category).HasMaxLength(50);
            builder.Property(u => u.Image).HasMaxLength(200);

            InsertListProduts(builder);
        }

        private void InsertListProduts(EntityTypeBuilder<Product> builder)
        {
            ////
            /// Carga inicial para a tabela Products
            ///
            builder.HasData(
                new Product() { Id = new Guid("f6b69aa6-e2f3-43f6-a05e-bd2197665248"), Title = "Produto Teste1", Price = 1.50M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("8c49293a-cb5d-4d5e-b974-b684d760e68b"), Title = "Produto Teste2", Price = 20.5M, Description = "batata doce", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("99e3da6e-a480-4f5f-8058-03f4a6840e88"), Title = "Produto Teste3", Price = 2.50M, Description = "tomnate", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("fb461642-0ab9-4c35-b267-db7245389144"), Title = "Produto Teste4", Price = 3.59M, Description = "cebola", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("053fe689-6338-4888-838f-f2d6e380320c"), Title = "Produto Teste5", Price = 10.90M, Description = "farrinha", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("234da59d-1e6c-426a-b63f-ca25991fadbb"), Title = "Produto Teste6", Price = 11.30M, Description = "macarrao", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("e08e8a39-a99f-44b8-9d02-7204edc46b20"), Title = "Produto Teste7", Price = 12.70M, Description = "conserva", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("50d5ceb1-a8a4-4f3a-beb5-5c5da018635b"), Title = "Produto Teste8", Price = 20.50M, Description = "doce de leite", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("7085290f-4c94-41b6-a26b-6942043b8284"), Title = "Produto Teste9", Price = 21.50M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("6889f9b5-e741-4356-a803-b9937cb3f431"), Title = "Produto Teste10", Price = 22.50M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("aa7955f3-6849-479a-810f-5009a44e7ffd"), Title = "Produto Teste11", Price = 23.75M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("0550fb96-50e5-4968-acc3-0af01870a18d"), Title = "Produto Teste12", Price = 150.03M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("74a0cc42-a507-4af2-abd7-a6bd60dc601c"), Title = "Produto Teste13", Price = 48.76M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("57ac8ad9-7c66-42db-aae7-ede32745aeb4"), Title = "Produto Teste14", Price = 55.76M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("9023a0cd-6ac3-497f-be5e-6d528f7a9447"), Title = "Produto Teste15", Price = 40.00M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("837c5d3a-537e-41e4-a1fc-205fe0800ed3"), Title = "Produto Teste16", Price = 100.51M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("b6ab9232-1fe8-40d3-9d5d-828b11041a2a"), Title = "Produto Teste17", Price = 200.47M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("c88ed001-4713-43e2-ab26-5afb06866daa"), Title = "Produto Teste18", Price = 3.50M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("0773a99f-40d2-4c24-8aaf-7d45e42ab856"), Title = "Produto Teste19", Price = 4.50M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("dc141325-4397-4608-a3f5-e2d99fbeea2b"), Title = "Produto Teste20", Price = 5.50M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("a0c0949c-c7fa-401f-8fcf-4874906bbd0b"), Title = "Produto Teste21", Price = 6.50M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("6105ddfe-636a-40b2-b3ec-77b695d2a528"), Title = "Produto Teste22", Price = 7.50M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("9f0f5a2f-6cca-459d-ad4e-133402183019"), Title = "Produto Teste23", Price = 8.50M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("b7301b08-10a7-4f88-b4ae-639bddf522cd"), Title = "Produto Teste24", Price = 9.50M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" },
                new Product() { Id = new Guid("6e94c72e-6c44-4068-a3ed-5868ad28f5bf"), Title = "Produto Teste25", Price = 0.50M, Description = "Leite em liquido", Category = "Alimentos", Image = "Image1" }
            );

        }

    }
}
