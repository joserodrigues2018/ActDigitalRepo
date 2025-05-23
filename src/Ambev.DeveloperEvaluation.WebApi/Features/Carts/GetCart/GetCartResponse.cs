using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart
{
    public class GetCartResponse
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public DateTime CartDate { get; set; }

        public IList<GetCartItemResponse>? Products { get; set; }
    }
}
