using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart
{
    public class GetCartItemResult
    {
        public Guid Id { get; set; }
        public Guid CartId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
