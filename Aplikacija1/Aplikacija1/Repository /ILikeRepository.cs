using System;
using Aplikacija1.Model;

namespace Aplikacija1.Repository
{
    public interface ILikeRepository
    {
        Like GetLikeById(int likeId);
        IEnumerable<Like> GetAllLikes();
        IEnumerable<Like> GetLikesForPost(int postId);
        IEnumerable<Like> GetLikesByUser(int userId);
        void AddLike(Like like);
        void RemoveLike(Like like);
    }
}

