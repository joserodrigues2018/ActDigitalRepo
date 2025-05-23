namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    public class CreateCartItemResult
    {
        public Guid CartId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
