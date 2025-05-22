using Ambev.DeveloperEvaluation.Application.Carts.CreateCart;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart
{
    public class CreateCartProfile:Profile
    {
        public CreateCartProfile()
        {
            CreateMap<CreateCartResquest, CreateCartCommand>();
            CreateMap<CreateCartItemResquest, CreateCartItemCommand>();
            CreateMap<CreateCartResult, CreateCartResponse>();
        }

    }
}
