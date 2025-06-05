using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class CartItemRepository: ICartItenRepository
    {
        private readonly DefaultContext _context;

        public CartItemRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<CartItem?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.CartItens.FirstOrDefaultAsync(f => f.Id.Equals(id),cancellationToken);
        }

        public async Task<bool> DeleteByIdAync(Guid Id, CancellationToken cancellationToken = default)
        {
            var cartItem = await GetByIdAsync(Id, cancellationToken);
            if (cartItem == null)
                return false;

            _context.CartItens.Remove(cartItem);
            await _context.SaveChangesAsync(cancellationToken);
            return true;

        }

        public async Task<CartItem?> UpdateIdAsync(CartItem cartItem, CancellationToken cancellationToken = default)
        {
            _context.Entry(cartItem).State = EntityState.Modified;

            _context.Update(cartItem);

            await _context.SaveChangesAsync(cancellationToken);

            return cartItem;
        }
    }
}
