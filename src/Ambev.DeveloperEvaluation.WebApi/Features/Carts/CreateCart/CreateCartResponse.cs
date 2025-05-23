using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    public class CreateCartResponse
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public DateTime CartDate { get; set; }

        public IList<CreateCartItemResponse>? Products { get; set; }
    }
}
