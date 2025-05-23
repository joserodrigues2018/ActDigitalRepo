namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale
{
    public class GetSaleResult
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public DateTime SaleDate { get; set; }

        public IList<GetSaleItemResult>? SaleOrderItems { get; set; } = [];
    }
}
