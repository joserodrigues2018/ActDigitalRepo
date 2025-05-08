using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface IProductRepository
    {
        /// <summary>
        /// Creates a new product in the repository
        /// </summary>
        /// <param name="product">The product to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created product</returns>
        Task<User> CreateAsync(Product product, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a product by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the product</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The product if found, null otherwise</returns>
        Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    }
}
