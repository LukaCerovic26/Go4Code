using System;
using Aplikacija1.DTOs;
using Aplikacija1.Model;

namespace Aplikacija1.Service
{
    public interface IPostService

    {
        public Task<PostsGetDetailsResponse> CreateAsync(PostsCreateRequest post);
        public Task<IEnumerable<PostsGetDetailsResponse>> GetAsync();
        public Task<PostsGetDetailsResponse> GetDetailsAsync(int id);
        public Task<bool> DeleteAsync(int id);

    }
}

