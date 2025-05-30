using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public  class SaleOrder: BaseEntity
    {
        public Guid CartId { get; set; }
        public int NumeroVenda { get; set; }
        public DateTime SaleDate { get; set; }
        public string? Client { get; set; }
        public decimal ValueTotal { get; set; }
        public string? Filial { get; set; }
        public SaleStatus Status { get; set; }

        public IList<SaleOrderItem>? Products { get; set; }

        public SaleOrder()
        {
            SaleDate = DateTime.UtcNow;
        }

    }
}
