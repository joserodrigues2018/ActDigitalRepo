using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class SalesOrderItemConfiguration
    {
        public SalesOrderItemConfiguration(EntityTypeBuilder<SaleOrderItem> builder) 
        {
            builder.ToTable("SaleOrderItems");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(u => u.SaleOrderId).IsRequired().HasConversion<string>();
            builder.Property(u => u.ProductId).IsRequired().HasConversion<string>();
            builder.Property(u => u.Quantity).IsRequired().HasConversion<int>();
            builder.Property(u => u.UnitPrice).IsRequired().HasPrecision(5, 2);
            builder.Property(u => u.ValueTotIten).IsRequired().HasPrecision(5, 2);
            builder.Property(u => u.PercentDiscount).IsRequired().HasConversion<int>();
        }
    }
}
