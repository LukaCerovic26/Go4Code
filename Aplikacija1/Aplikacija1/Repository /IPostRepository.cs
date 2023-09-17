using System;
using Aplikacija1.Model;

namespace Aplikacija1.Repository
{
    public interface IPostRepository
    {
        public Task<Post> Create(Post post);
        public Task<IEnumerable<Post>> GetAll();
        public Task<Post> Get(int id);
        public Task Delete(Post post);
    }

}

