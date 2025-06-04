namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart
{
    public class UpdateCartItemResult
    {
        public Guid CartId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
