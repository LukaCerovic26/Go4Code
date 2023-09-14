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
        }
    }
}


