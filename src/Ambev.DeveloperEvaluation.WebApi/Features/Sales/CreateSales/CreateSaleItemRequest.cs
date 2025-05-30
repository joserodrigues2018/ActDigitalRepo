namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales
{
    public class CreateSaleItemRequest
    {
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
