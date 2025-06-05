using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Users.UpdateUser;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.UpdateUser;

/// <summary>
/// Profile for mapping between Application and API UpdateUser responses
/// </summary>
public class UpdateUserProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for UpdateUser feature
    /// </summary>
    public UpdateUserProfile()
    {
        CreateMap<UpdateUserIdRequest, UpdateUserCommand>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))       
                                                           .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Request!.Username))
                                                           .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Request!.Password))
                                                           .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Request!.Phone))
                                                           .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Request!.Email))
                                                           .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Request!.Status))
                                                           .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Request!.Role));

        CreateMap<UpdateUserResult, UpdateUserResponse>();
    }
}
