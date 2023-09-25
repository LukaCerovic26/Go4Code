using System;
using Aplikacija1.DTOs;
using Aplikacija1.Model;
using Aplikacija1.Repository;
using AutoMapper;

namespace Aplikacija1.Service

{
    public class PostServiceIMPL : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        private readonly ILikeRepository _likesRepository;

        public PostServiceIMPL(IPostRepository repository, IMapper mapper, ILikeRepository likesRepository)
        {
            _postRepository = repository;
            _mapper = mapper;
            _likesRepository = likesRepository;
        }

        public async Task<PostsGetDetailsResponse> CreateAsync(PostsCreateRequest post)
        {
            var postEntity = _mapper.Map<Post>(post);
            var result = await _postRepository.Create(postEntity);

            return _mapper.Map<PostsGetDetailsResponse>(result);
           
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var exists = await _postRepository.Get(id);
            if(exists == null)
            {
                return false;
            }
            await _postRepository.Delete(exists);
            return true;
            
        }

        public async Task<IEnumerable<PostsGetDetailsResponse>> GetAsync()
        {
            var posts = await _postRepository.GetAll();
            return _mapper.Map<IEnumerable<PostsGetDetailsResponse>>(posts);
        }

        public async Task<PostsGetDetailsResponse> GetDetailsAsync(int id)
        {
            var post = await _postRepository.Get(id);
            var likes = await _likesRepository.GetLikesForPost(post.Id);
            post.Likes = likes.ToList();
            if (post == null)
                return null;

            return _mapper.Map<PostsGetDetailsResponse>(post);
            
        }
    }
}

