using AutoMapper;
using Blog.Domain.Entities;
using Blog.Application.DTOs;

namespace Blog.Application.Profiles;

public class MappingProfile : Profile {
    public MappingProfile() {
        CreateMap<Post, PostDto>().ReverseMap();
        CreateMap<Comment, CommentDto>().ReverseMap();
    }     
}
