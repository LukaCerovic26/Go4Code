using System;
using AutoMapper;
using Aplikacija1.DTOs;
using Aplikacija1.Model;

namespace Aplikacija1.Mapping
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Post, PostsCreateRequest>().ReverseMap();
            CreateMap<Post, PostsGetDetailsResponse>().ReverseMap();
            CreateMap<Comment, CommentsCreateRequest>().ReverseMap();
            CreateMap<Like, LikesCreateRequest>().ReverseMap();
            CreateMap<User, LoginUserRequest>().ReverseMap();
            CreateMap<User, RegisterUserRequest>().ReverseMap();
        }
    }
}


