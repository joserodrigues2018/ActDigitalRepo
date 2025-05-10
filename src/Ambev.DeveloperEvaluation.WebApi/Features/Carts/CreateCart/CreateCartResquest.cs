namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    public class CreateCartResquest
    {
        public string? UserId { get; set; }
        public DateTime DateRegistro { get; set; }

        public IList<CreateCartItemResquest>? CartItens { get; set; }
    }
}
