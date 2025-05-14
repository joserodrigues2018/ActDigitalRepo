namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    public class CreateCartResquest
    {
        public string? UserId { get; set; }
        public string? Client { get; set; }
        public DateTime CartDate { get; set; }
        public string? Filial { get; set; }

        public IList<CreateCartItemResquest>? CartItens { get; set; }
    }
}
