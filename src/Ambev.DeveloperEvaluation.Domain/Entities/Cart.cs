using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public  class Cart: BaseEntity
    {
        public string? UserId { get; set; }
        public DateTime CartDate { get; set; }

        public IList<CartItem>? Products { get; set; }

        public Cart()
        {
            CartDate = DateTime.UtcNow;
        }
    }
}
