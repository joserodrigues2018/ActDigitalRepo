namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    public class CreateCartResponse
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public string? Client { get; set; }
        public DateTime CartDate { get; set; }
        public decimal ValueTotal { get; set; }
        public string? Filial { get; set; }
        public string? StatusCart { get; set; }

        public IList<CreateCartItemResponse>? CartItems { get; set; }
    }
}
