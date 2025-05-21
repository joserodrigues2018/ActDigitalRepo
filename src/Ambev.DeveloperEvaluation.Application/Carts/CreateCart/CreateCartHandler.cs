using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Services;
using Ambev.DeveloperEvaluation.Domain.Enums;
using System.Reflection.Metadata.Ecma335;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    public class CreateCartHandler: IRequestHandler<CreateCartCommand, CreateCartResult>
    {
        private readonly IRulesDiscountCart _ruleDiscountCart;
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public CreateCartHandler(IRulesDiscountCart ruleDiscountCart, ICartRepository cartRepository, IMapper mapper, IProductRepository productRepository  )
        {
            _ruleDiscountCart = ruleDiscountCart;
            _cartRepository = cartRepository;
            _mapper = mapper;
            _productRepository = productRepository;
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

            foreach (var item in cart.CartItens!)
            {
                var product = await _productRepository.GetByIdAsync(Guid.Parse(item.ProductId!.ToString()), cancellationToken);

                if (product != null)
                {
                    item.UnitPrice = product.Price;

                    var cartItemNew = await _ruleDiscountCart.DiscountCart(item, cancellationToken);

                    item.StatusIten = cartItemNew.StatusIten;
                    item.Discount = cartItemNew.Discount;

                    cart.ValueTotal += cartItemNew.ValueTotIten;
                }
            }

            cart.NumeroVenda = new Random().Next();
            cart.StatusCart = CartStatus.VendaCriada;

            var createCart = await _cartRepository.CreateAsync(cart, cancellationToken);

            var result = _mapper.Map<CreateCartResult>(createCart);

            return result;
        }
    }
}
