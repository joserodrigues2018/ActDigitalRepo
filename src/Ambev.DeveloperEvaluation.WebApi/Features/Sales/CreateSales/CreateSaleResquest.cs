using Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleResquest
    {
        public Guid CartId { get; set; }
        public string? Client { get; set; }
        public string? Filial { get; set; }

        public IList<CreateSaleItemRequest>? Products { get; set; }   
    }
}
