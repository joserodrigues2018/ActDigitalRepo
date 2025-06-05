using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ICartItenRepository
    {
        Task<CartItem?> CreateIdAsync(CartItem cartItem, CancellationToken cancellationToken = default);
        Task<CartItem?> GetByIdAsync(Guid Id, CancellationToken cancellationToken = default);
        Task<CartItem?> UpdateIdAsync(CartItem cartItem, CancellationToken cancellationToken = default);
        Task<bool> DeleteByIdAync(Guid Id, CancellationToken cancellationToken = default);
    }
}
