using System;
using Aplikacija1.DTOs;
using Aplikacija1.Model;

namespace Aplikacija1.Service
{
    public interface ICommentService
    {
        public Task<CommentsGetDetailsResponse> CreateAsync(CommentsCreateRequest post);
        public Task<IEnumerable<CommentsGetDetailsResponse>> GetAsync();
        public Task<CommentsGetDetailsResponse> GetDetailsAsync(int id);
        public Task<bool> DeleteAsync(int id);

    }
}

