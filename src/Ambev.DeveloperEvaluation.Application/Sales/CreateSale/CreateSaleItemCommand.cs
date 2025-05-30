namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleItemCommand
    {
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
