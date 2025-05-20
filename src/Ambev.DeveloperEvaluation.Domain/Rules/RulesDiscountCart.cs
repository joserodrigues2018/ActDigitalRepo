using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Services;

namespace Ambev.DeveloperEvaluation.Domain.Rules
{
    public class RulesDiscountCart : IRulesDiscountCart
    {
        private readonly IProductRepository _productRepository;
        private readonly ICalcDiscount _calcDiscount;

        public RulesDiscountCart(IProductRepository productRepository, ICalcDiscount calcDiscount)
        {
            _productRepository = productRepository;
            _calcDiscount = calcDiscount;
        }

        public async Task<Cart> DiscountCart(Cart cart, CancellationToken cancellationToken)
        {
            foreach (var item in cart.CartItens!)
            {
                var product = await _productRepository.GetByIdAsync(Guid.Parse(item.ProductId!.ToString()), cancellationToken);

                if (product == null)
                    throw new KeyNotFoundException($"Product with ID {item.ProductId} not found");

                item.UnitPrice = product.Price;

                var valorItem = item.Quantity * item.UnitPrice;

                if (item.Quantity >= 4 && item.Quantity <= 9)
                {
                    item.Discount = 10;
                }
                else if (item.Quantity >= 10 && item.Quantity <= 20)
                {
                    item.Discount = 20;
                }
                else
                {
                    item.Discount = 0;
                }

                decimal valorDiscount = item.Discount == 0 ? 0 : _calcDiscount.ApplyDiscount(item.UnitPrice, item.Quantity, item.Discount);

                item.ValueTotIten = valorDiscount == 0 ? valorItem:(valorItem - valorDiscount);

                item.StatusIten = CartStatus.VendaCriada;

                cart.ValueTotal += item.ValueTotIten;
            }

            cart.NumeroVenda = new Random().Next();
            cart.StatusCart = CartStatus.VendaCriada;

            return cart;
        }
    }
}
