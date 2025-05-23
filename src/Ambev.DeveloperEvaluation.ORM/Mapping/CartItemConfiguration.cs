using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class CartItemConfiguration
    {
        public CartItemConfiguration(EntityTypeBuilder<CartItem> builder)
        {

            builder.ToTable("CartItems");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");
            builder.Property(u => u.CartId).IsRequired().HasConversion<string>(); 
            builder.Property(u => u.ProductId).IsRequired().HasConversion<string>();
            builder.Property(u => u.Quantity).IsRequired().HasConversion<int>();

        }
    }
}
