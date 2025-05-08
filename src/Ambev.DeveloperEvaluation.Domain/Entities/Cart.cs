using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public  class Cart: BaseEntity
    {
        public int UserId { get; set; }
        public DateTime DateRegistro { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
