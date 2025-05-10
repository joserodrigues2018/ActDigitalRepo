using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class SaleOrderItem: BaseEntity
    {
        public Guid SaleOrderId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public decimal ValueTotIten { get; set; }
        public string? StatusIten { get; set; }

        public SaleOrder? SaleOrderNav { get; set; }
    }
}
