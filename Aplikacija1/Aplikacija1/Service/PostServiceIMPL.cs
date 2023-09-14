using System;
using Aplikacija1.Model;
using Aplikacija1.Repository;
using AutoMapper;

namespace Aplikacija1.Service

{
    public class PostServiceIMPL : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostServiceIMPL(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _postRepository.GetAllPosts();
        }

        public Post GetPostById(int postId)
        {
            return _postRepository.GetPostById(postId);
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

