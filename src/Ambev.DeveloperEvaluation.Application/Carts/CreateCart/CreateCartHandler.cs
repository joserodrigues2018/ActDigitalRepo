using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using System.Reflection.Metadata.Ecma335;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    public class CreateCartHandler: IRequestHandler<CreateCartCommand, CreateCartResult>
    {
        private readonly IProductRepository _productRepository;
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        public CreateCartHandler(IProductRepository productRepository,ICartRepository cartRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _cartRepository = cartRepository;
            _mapper = mapper;
        }
        /// <summary>
        /// Handles the CreateCartCommand request
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ValidationException"></exception>
        public async Task<CreateCartResult> Handle(CreateCartCommand command, CancellationToken cancellationToken)
        {
            var validator = new CreateCartCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var cart = _mapper.Map<Cart>(command);

            await DiscountCart(cart, cancellationToken);

            var createCart = await _cartRepository.CreateAsync(cart, cancellationToken);

            var result = _mapper.Map<CreateCartResult>(createCart);

            return result;
        }

        public async Task DiscountCart(Cart cart, CancellationToken cancellationToken)
        {
            foreach (var item in cart.CartItens!)
            {
                var product = await _productRepository.GetByIdAsync(Guid.Parse(item.ProductId!.ToString()), cancellationToken);

                if (product == null)
                    throw new KeyNotFoundException($"Product with ID {item.ProductId} not found");

                item.UnitPrice = product.Price;

                if (item.Quantity > 4 && item.Quantity <= 5)
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

                var valorItem = item.Quantity * item.UnitPrice;

                var valorDiscount = (item.Quantity * item.UnitPrice * item.Discount) / 100;

                item.ValueTotIten = valorItem - valorDiscount;

                item.StatusIten = CartStatus.VendaCriada;

                cart.ValueTotal += item.ValueTotIten;                
            }

            cart.NumeroVenda = new Random().Next();
            cart.StatusCart = CartStatus.VendaCriada;        
        }
    }
}
