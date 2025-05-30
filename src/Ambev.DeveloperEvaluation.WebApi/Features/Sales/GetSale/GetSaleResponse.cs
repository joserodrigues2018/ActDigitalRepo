using Ambev.DeveloperEvaluation.Application.Sales.GetSale;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale
{
    public class GetSaleResponse
    {
        public Guid Id { get; set; }
        public Guid CartId { get; set; }
        public int NumeroVenda { get; set; }
        public DateTime SaleDate { get; set; }
        public string? Client { get; set; }
        public decimal ValueTotal { get; set; }
        public string? Filial { get; set; }
        public SaleStatus Status { get; set; }

        public IList<GetSaleItemResult>? Products { get; set; }
    }
}
