using System;
using Aplikacija1.Model;

namespace Aplikacija1.Repository
{
    public interface ILikeRepository
    {

        public Task<Like> Create(Like like);
        public Task<Like> Get(int id);
        public Task <IEnumerable<Like>> GetAll();
        public Task <IEnumerable<Like>> GetLikesForPost(int postId);
        public Task <IEnumerable<Like>> GetLikesByUser(int userId);
        public Task Delete(Like like);
    }
}

//Like GetLikeById(int likeId);
//void AddLike(Like like);
//void RemoveLike(Like like);