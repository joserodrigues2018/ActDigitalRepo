using Ambev.DeveloperEvaluation.Application.Carts.CreateCart;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentAssertions;
using NSubstitute;
using NSubstitute.ReceivedExtensions;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Application
{
    public  class CreateCartHandlerTests
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;
        private readonly CreateCartHandler _createCartHandler;

        public CreateCartHandlerTests() 
        {
            _cartRepository = Substitute.For<ICartRepository>();
            _mapper = Substitute.For<IMapper>();

            _createCartHandler = new CreateCartHandler( _cartRepository, _mapper);

        }

        [Fact(DisplayName = "Unit Test create Cart sucess")]
        public async Task Create_CartHandle_Sucess()
        {
            // Given
            var command = CreateCartHandlerTestData.GenerateCartFaker();

            var cart = new Cart
            {
                UserId = command.UserId,
                CartDate = command.CartDate,
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

            var cartResult = new CreateCartResult
            {
                UserId = command.UserId,
                CartDate = command.CartDate,
            };

            _mapper.Map<Cart>(command).Returns(cart);

            _cartRepository.CreateAsync(Arg.Any<Cart>(), Arg.Any<CancellationToken>()).Returns(cart);

            _mapper.Map<CreateCartResult>(cart).Returns(cartResult);

            // When
            var createCartResult = await _createCartHandler.Handle(command, CancellationToken.None);

            // Then

            cartResult.Should().NotBeNull();
            createCartResult.Id.Should().Be(cart.Id);
            await _cartRepository.Received(1).CreateAsync(Arg.Any<Cart>(), Arg.Any<CancellationToken>());
        }

        [Fact(DisplayName = "Unit Test validation error")]
        public async Task Create_Cart_Handle_ValidationException()
        {
            // Given
            var command = new CreateCartCommand();

            // When
            var act = () =>  _createCartHandler.Handle(command, CancellationToken.None);

            // Then
            await act.Should().ThrowAsync<FluentValidation.ValidationException>();

        }
    }
}
