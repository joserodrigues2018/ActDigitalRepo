using Ambev.DeveloperEvaluation.Application.Carts.CreateCart;
using Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings.Carts
{
    public class CreateCartRequestProfile: Profile
    {
        public CreateCartRequestProfile()
        {
            CreateMap<CreateCartResquest, CreateCartCommand>();
        }
    }
}
