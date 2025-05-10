using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class SaleOrder: BaseEntity
    {
        public string? Client { get; set; }
        public string? DateOrder { get; set; }
        public decimal ValueTotal { get; set; }
        public string? Filial { get; set; }
        public decimal Discount { get; set; }
        public string? StatusOrder { get; set; }

        public IList<SaleOrderItem>? SaleOrderItens { get; set; }

        public SaleOrder()
        {
            DateOrder = DateTime.UtcNow.ToString();            
        }
    }
}
