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
            var CartItens = await _context.Carts.Include(c => c.CartItens).ToListAsync(cancellationToken);

            return await _context.Carts.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Cart> CreateAsync(Cart Cart, CancellationToken cancellationToken)
        {
            await _context.Carts.AddAsync(Cart, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return Cart;
        }
    }
}
