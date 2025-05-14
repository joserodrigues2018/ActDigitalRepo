using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Carts.GetCart;
using Ambev.DeveloperEvaluation.Application.Carts.CreateCart;
using Ambev.DeveloperEvaluation.WebApi.Features.Carts.CreateCart;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart
{
    public class GetCartProfile: Profile
    {
        public GetCartProfile()
        {
            CreateMap<Guid, GetCartCommand>()
                .ConstructUsing(id => new GetCartCommand(id));
            CreateMap<GetCartResult, GetCartResponse>();
        }
    }
}
