namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart
{
    public class UpdateCartItemCommand
    {
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
