using Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.UpdateProduct
{
    public class UpdateProductProfile:Profile
    {
        public UpdateProductProfile()
        {
            CreateMap<UpdateProductIdRequest, UpdateProductCommand>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                                                                     .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Request!.Title))
                                                                     .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Request!.Price))
                                                                     .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Request!.Description))
                                                                     .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Request!.Category))
                                                                     .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Request!.Image));

            CreateMap<UpdateProductResult, UpdateProductResponse>();
        }

    }
}
