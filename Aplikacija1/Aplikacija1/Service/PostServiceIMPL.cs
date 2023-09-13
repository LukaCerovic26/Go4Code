using System;
using Aplikacija1.Model;
using Aplikacija1.Repository;

namespace Aplikacija1.Service
{
	public class PostServiceIMPL
	{
        public class PostService
        {
            private readonly IPostRepository _postRepository;

            public PostService(IPostRepository postRepository)
            {
                _postRepository = postRepository;
            }

            // POSLOVNA LOGIKA

            public Post GetPostById(int postId)
            {
                return _postRepository.GetPostById(postId);
            }

            public IEnumerable<Post> GetAllPosts()
            {
                return _postRepository.GetAllPosts();
            }

            public void AddPost(Post post)
            {
                _postRepository.AddPost(post);
            }

            public void UpdatePost(Post post)
            {
                _postRepository.UpdatePost(post);
            }

            public void DeletePost(Post post)
            {
                _postRepository.DeletePost(post);
            }
        }
    }
}

