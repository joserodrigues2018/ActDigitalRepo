using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class CartItem: BaseEntity
    {
        public Guid CartId { get; set; }
        public string? ProductId { get; set; }
        public int Quantity { get; set; }

    }
} 
