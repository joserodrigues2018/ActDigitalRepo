using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Enums
{
    public class SaleOrderItem: BaseEntity
    {
        public Guid SaleId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ValueTotIten { get; set; }
        public int PercentDiscount { get; set; }
    }
}
