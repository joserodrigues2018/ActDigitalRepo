namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    public class CreateCartItemResquest
    {

        public Guid CartId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
