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
            builder.Property(u => u.Filial).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Client).IsRequired().HasMaxLength(100);
            builder.Property(u => u.ValueTotal).IsRequired().HasPrecision(5, 2);
            builder.Property(u => u.StatusCart)
                    .HasConversion<string>()
                    .HasMaxLength(20);

        }
    }
}
