using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public  class Cart: BaseEntity
    {
        public string? UserId { get; set; }
        public DateTime DateRegistro { get; set; }
        //public IList<CartIten>? CartItens { get; set; }

        public Cart()
        {
            DateRegistro = DateTime.UtcNow;
        }
    }
}
