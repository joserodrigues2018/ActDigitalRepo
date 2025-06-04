using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class CartItemRepository: ICartItenRepository
    {
        private readonly DefaultContext _context;

        public CartItemRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteAync(List<CartItem> cartItems, CancellationToken cancellationToken = default)
        {
            _context.CartItens.RemoveRange(cartItems);

            await _context.SaveChangesAsync(cancellationToken);

            return true;

        }
    }
}
