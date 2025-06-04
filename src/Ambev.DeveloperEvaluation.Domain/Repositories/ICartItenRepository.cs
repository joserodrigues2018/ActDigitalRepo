using Ambev.DeveloperEvaluation.Domain.Entities;
using System.Collections.Generic;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ICartItenRepository
    {
        Task<bool> DeleteAync(List<CartItem> cartItems, CancellationToken cancellationToken = default);
    }
}
