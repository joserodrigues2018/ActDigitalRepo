using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Carts.GetCart;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.GetCart
{
    public class GetCartProfile: Profile
    {
        public GetCartProfile()
        {
            CreateMap<Guid, GetCartCommand>()
                .ConstructUsing(id => new GetCartCommand(id));

            CreateMap<GetCartResult, GetCartResponse>();
            CreateMap<GetCartItemResult, GetCartItemResponse>();
        }
    }
}
