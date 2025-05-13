namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    public class CreateCartItemResponse
    {
        public Guid CartId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? ValueTotIten { get; set; }
        public int Discount { get; set; }
        public string? StatusIten { get; set; }
    }
}
