using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly DefaultContext _context;

        public CartRepository(DefaultContext context)
        {
            _context = context;       
        }

        public async Task<Cart?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            await _context.Carts.Include(c => c.Products).ToListAsync(cancellationToken);

            return await _context.Carts.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Cart> CreateAsync(Cart cart, CancellationToken cancellationToken)
        {
            await _context.Carts.Include(c => c.Products).ToListAsync(cancellationToken);

            await _context.Carts.AddRangeAsync(cart);
            await _context.SaveChangesAsync(cancellationToken);

            return cart;
        }

        public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var cart = await GetByIdAsync(id, cancellationToken);
            if (cart == null)
                return false;

            _context.Carts.Remove(cart);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Cart> UpdateAsync(Cart cart, CancellationToken cancellationToken = default)
        {
            _context.Entry(cart).State = EntityState.Modified;

            await _context.Carts.Include(c => c.Products).ToListAsync(cancellationToken);

            _context.Carts.Update(cart);

            await _context.SaveChangesAsync(cancellationToken);

            return cart;
        }
    }
}
