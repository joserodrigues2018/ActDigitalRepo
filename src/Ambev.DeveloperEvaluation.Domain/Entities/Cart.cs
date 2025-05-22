using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public  class Cart: BaseEntity
    {
        public string? UserId { get; set; }
        public DateTime CartDate { get; set; }
        public IList<CartItem>? CartItens { get; set; }

        public Cart()
        {
            CartDate = DateTime.UtcNow;
        }
    }
}
