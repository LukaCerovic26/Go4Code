using System;
using Aplikacija1.Model;

namespace Aplikacija1.Repository
{
    public interface IPostRepository
    {
        Post GetPostById(int postId);
        IEnumerable<Post> GetAllPosts();
        void AddPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(Post post);
    }

}

