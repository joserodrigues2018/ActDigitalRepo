using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Services;

namespace Ambev.DeveloperEvaluation.Application.Carts.CreateCart
{
    public class CreateCartHandler: IRequestHandler<CreateCartCommand, CreateCartResult>
    {
        private readonly IRulesDiscountCart _ruleDiscountCart;
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        public CreateCartHandler(IRulesDiscountCart ruleDiscountCart, ICartRepository cartRepository, IMapper mapper)
        {
            _ruleDiscountCart = ruleDiscountCart;
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

            var cartRuletDiscount = await _ruleDiscountCart.DiscountCart(cart, cancellationToken);

            var createCart = await _cartRepository.CreateAsync(cartRuletDiscount, cancellationToken);

            var result = _mapper.Map<CreateCartResult>(createCart);

            return result;
        }
    }
}
