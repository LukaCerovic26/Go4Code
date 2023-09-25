using System;
using Aplikacija1.DTOs;
using Aplikacija1.Model;
using Aplikacija1.Repository;
using AutoMapper;
using Microsoft.Extensions.Hosting;

namespace Aplikacija1.Service
{
    public class LikeServiceIMPL : ILikeService
    {
        private readonly ILikeRepository _likeRepository;
        private readonly IMapper _mapper;

        public LikeServiceIMPL(ILikeRepository likeRepository, IMapper mapper)
        {
            _likeRepository = likeRepository;
            _mapper = mapper;
        }

        public async Task<Like> GetLikeById(int likeId)
        {
            return await _likeRepository.Get(likeId);
        }

        public async Task<IEnumerable<Like>> GetAllLikes()
        {
            return await _likeRepository.GetAll();
        }

        public async Task<IEnumerable<Like>> GetLikesForPost(int postId)
        {
            return await _likeRepository.GetLikesForPost(postId);
        }

        public async Task<IEnumerable<Like>> GetLikesByUser(String userId)
        {
            return await _likeRepository.GetLikesByUser(userId);
        }

        public async Task<Like> CreateLike(LikesCreateRequest request)
        {
            var likeEntity = _mapper.Map<Like>(request);
            var result = await _likeRepository.Create(likeEntity);

            return _mapper.Map<Like>(result);
        }

        public async Task<bool> DeleteLike(LikesDeleteRequest request)
        {
            var likes = await _likeRepository.GetLikesForPost(request.PostId);
            var exists = likes.First(like => like.UserId == request.UserId);
            if (exists == null)
            {
                return false;
            }
            await _likeRepository.Delete(exists);
            return true;
        }
    }
}

