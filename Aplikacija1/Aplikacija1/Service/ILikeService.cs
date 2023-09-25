using System;
using Aplikacija1.DTOs;
using Aplikacija1.Model;

namespace Aplikacija1.Service
{
    public interface ILikeService
    {
       public Task <Like> GetLikeById(int likeId);
       public Task <IEnumerable<Like>> GetAllLikes();
       public Task <IEnumerable<Like>> GetLikesForPost(int postId);
       public Task <IEnumerable<Like>> GetLikesByUser(String userId);
       public Task <Like> CreateLike(LikesCreateRequest request);
       public Task <bool> DeleteLike(LikesDeleteRequest request);
    }
}


