using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class CartConfiguration
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(u => u.UserId).IsRequired().HasConversion<string>();
            builder.Property(u => u.DateRegistro).IsRequired().HasColumnType("date");
            builder.Property(u => u.ProductId).IsRequired();
            builder.Property(u => u.Quantity).IsRequired();
        }
    }
}
