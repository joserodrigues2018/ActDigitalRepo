using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    public class CreateCartResult
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public DateTime CartDate { get; set; }

        public IList<CreateCartItemResult>? Products { get; set; }  
    }
}
