using Ambev.DeveloperEvaluation.Application.Products.CreateProduct;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using Bogus;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Application
{
    public  class CreateProductHandlerTests
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly CreateProductHandler _createProductHandler;

        private readonly Faker<CreateProductCommand> _createProductFaker = new Faker<CreateProductCommand>()
            .RuleFor(p => p.Title, f => f.Commerce.ProductName())
            .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
            .RuleFor(p => p.Category, f => f.Commerce.Categories(1).FirstOrDefault())
            .RuleFor(p => p.Price, 40.55M)
            .RuleFor(p => p.Image , "Sem imagem");

        public CreateProductHandlerTests()
        {
            _productRepository = Substitute.For<IProductRepository>();
            _mapper = Substitute.For<IMapper>();
            _createProductHandler = new CreateProductHandler(_productRepository, _mapper);            
        }

        [Fact(DisplayName = "Unit Test response sucess")]
        public async Task Create_ProductHandle_ReqonseSucess()
        {
            // Given

            var fakerProduct = _createProductFaker.Generate();

            var product = new Product
            {   
                Id = new Guid(),
                Title =fakerProduct.Title,
                Description =fakerProduct.Description,
                Category = fakerProduct.Category,
                Price = fakerProduct.Price,
                Image = fakerProduct.Image
            };

            var result = new CreateProductResult {  Id = product.Id};

            _mapper.Map<Product>(fakerProduct).Returns(product);
            _mapper.Map<CreateProductResult>(product).Returns(result);

            _productRepository.CreateAsync(Arg.Any<Product>(), Arg.Any<CancellationToken>())
                .Returns(product);

            // When
            var createUserResult = await _createProductHandler.Handle(fakerProduct, CancellationToken.None);

            // Then
            createUserResult.Should().NotBeNull();
            createUserResult.Id.Should().Be(product.Id);
            await _productRepository.Received(1).CreateAsync(Arg.Any<Product>(), Arg.Any<CancellationToken>());
        }
    }
}
