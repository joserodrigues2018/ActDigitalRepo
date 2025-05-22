namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart
{
    public class GetCartResult
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public DateTime CartDate { get; set; }

        public IList<GetCartItemResult>? Products { get; set; } = [];
    }
}
