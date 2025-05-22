namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    public class CreateCartItemCommand
    {
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
