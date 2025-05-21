using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Services
{
    public interface IRulesDiscountCart
    {
        Task<CartItem> DiscountCart(CartItem cartitem, CancellationToken cancellationToken);
    }
}
