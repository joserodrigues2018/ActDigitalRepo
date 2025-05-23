namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale
{
    public class CreateSaleItemResponse
    {
        public Guid Id { get; set; }
        public Guid SaleId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ValueTotIten { get; set; }
        public int PercentDiscount { get; set; }
    }
}
