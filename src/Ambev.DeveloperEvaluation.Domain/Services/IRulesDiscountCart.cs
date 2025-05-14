using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Services
{
    public interface IRulesDiscountCart
    {
        Task<Cart> DiscountCart(Cart cart, CancellationToken cancellationToken);
    }
}
