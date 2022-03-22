using AutoMapper;
using OlayaDigital.Core.DTOs;
using OlayaDigital.Core.Entities;

namespace OlayaDigital.Infrastructure.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, PostDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Media, MediaDto>().ReverseMap();
            CreateMap<Comment, CommentDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
