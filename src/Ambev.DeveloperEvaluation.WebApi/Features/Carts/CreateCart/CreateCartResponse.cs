namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    public class CreateCartResponse
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public DateTime DateRegistro { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
