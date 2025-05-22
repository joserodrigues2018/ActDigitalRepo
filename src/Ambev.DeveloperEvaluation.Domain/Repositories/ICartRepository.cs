using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ICartRepository
    {
        /// <summary>
        /// Creates a new Cart in the repository
        /// </summary>
        /// <param name="Cart">The Cart to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created Cart</returns>
        Task<Cart> CreateAsync(Cart cart, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a Cart by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the Cart</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The Cart if found, null otherwise</returns>
        Task<Cart?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    }
}
