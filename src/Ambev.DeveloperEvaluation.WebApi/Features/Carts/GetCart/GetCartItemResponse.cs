using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart
{
    public class GetCartItemResponse
    {
        public Guid Id { get; set; }
        public Guid CartId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? ValueTotIten { get; set; }
        public int Discount { get; set; }
        public CartStatus StatusIten { get; set; }
    }
}
