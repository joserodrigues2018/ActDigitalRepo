using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart
{
    public class GetCartItemResponse
    {
        public Guid Id { get; set; }
        public Guid CartId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
