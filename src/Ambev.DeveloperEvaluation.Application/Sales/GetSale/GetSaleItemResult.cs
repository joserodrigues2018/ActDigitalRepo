namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale
{
    public class GetSaleItemResult
    {
        public Guid Id { get; set; }
        public Guid SaleOrderId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ValueTotIten { get; set; }
        public int PercentDiscount { get; set; }
    }
}
