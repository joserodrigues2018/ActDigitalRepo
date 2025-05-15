using Ambev.DeveloperEvaluation.Application.Carts.CreateCart;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Rules;
using Ambev.DeveloperEvaluation.Domain.Services;
using Ambev.DeveloperEvaluation.Unit.Application.Cart;
using AutoMapper;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Application
{
    public  class CreateCartHandlerTests
    {
        private readonly IRulesDiscountCart _ruleDiscountCart;
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;
        private readonly CreateCartHandler _createCartHandler;

        public CreateCartHandlerTests() 
        {
            _ruleDiscountCart = Substitute.For<IRulesDiscountCart>();
            _cartRepository = Substitute.For<ICartRepository>();
            _mapper = Substitute.For<IMapper>();

            _createCartHandler = new CreateCartHandler(_ruleDiscountCart, _cartRepository, _mapper);

        }

        [Fact(DisplayName = "Unit Test create Cart sucess")]
        public async Task Create_CartHandle_Sucess()
        {
            // Given
            var command = CreateCartHandlerTestData.GenerateCartFaker();

            var cart = new Ambev.DeveloperEvaluation.Domain.Entities.Cart
            {
                UserId = command.UserId,
                Client = command.Client,
                CartDate = command.CartDate,
                Filial = command.Filial,
                CartItens = []
            };

            foreach (var item in command!.CartItens!)
            {
                var cartItem = new CartItem
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };

                cart.CartItens.Add(cartItem);
            }

            var result = new CreateCartResult
            { 
                UserId = command.UserId,
                Client = command.Client
            };

            _mapper.Map<Ambev.DeveloperEvaluation.Domain.Entities.Cart>(command).Returns(cart);
            _mapper.Map<CreateCartResult>(cart).Returns(result);

            _cartRepository.CreateAsync(Arg.Any<Ambev.DeveloperEvaluation.Domain.Entities.Cart>(), Arg.Any<CancellationToken>())
                .Returns(cart);

            _ruleDiscountCart.DiscountCart(Arg.Any<Ambev.DeveloperEvaluation.Domain.Entities.Cart>(),
                                                                CancellationToken.None).Returns(cart);
            // When

            var createCartResult = await _createCartHandler.Handle(command, CancellationToken.None);

            // Then
            createCartResult.Should().NotBeNull();
            createCartResult.Id.Should().Be(cart.Id);
            await _cartRepository.Received(1).CreateAsync(Arg.Any<Ambev.DeveloperEvaluation.Domain.Entities.Cart>(), Arg.Any<CancellationToken>());
        }
    }
}
