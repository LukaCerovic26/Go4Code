using System;
using Aplikacija1.Model;
using Aplikacija1.Repository;

namespace Aplikacija1.Service
{
    public class LikeService
    {
        private readonly ILikeRepository _likeRepository;

        public LikeService(ILikeRepository likeRepository)
        {
            _likeRepository = likeRepository;
        }

        // Implementiram  poslovnu logiku

        public Like GetLikeById(int likeId)
        {
            return _likeRepository.GetLikeById(likeId);
        }

        public IEnumerable<Like> GetAllLikes()
        {
            return _likeRepository.GetAllLikes();
        }

        public IEnumerable<Like> GetLikesForPost(int postId)
        {
            return _likeRepository.GetLikesForPost(postId);
        }

        public IEnumerable<Like> GetLikesByUser(int userId)
        {
            return _likeRepository.GetLikesByUser(userId);
        }

        public void AddLike(Like like)
        {
            _likeRepository.AddLike(like);
        }

        public void RemoveLike(Like like)
        {
            _likeRepository.RemoveLike(like);
        }
    }
}

