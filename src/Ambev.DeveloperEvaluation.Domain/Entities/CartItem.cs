using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class CartItem: BaseEntity
    {
        public Guid CartId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }

        public Cart? CartIdNav { get; set; }
    }
} 
