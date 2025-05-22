namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    public class CreateCartResquest
    {
        public string? UserId { get; set; }
        public DateTime CartDate { get; set; }

        public IList<CreateCartItemResquest>? Products { get; set; }
    }
}
