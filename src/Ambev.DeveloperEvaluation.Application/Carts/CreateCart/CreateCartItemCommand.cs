namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    public class CreateCartItemCommand
    {
        public Guid CartId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
