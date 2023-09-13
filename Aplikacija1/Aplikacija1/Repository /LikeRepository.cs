using System;
using Aplikacija1.Model;

namespace Aplikacija1.Repository
{
    public class LikeRepository : ILikeRepository
    {
        private readonly ApplicationDbContext _context;

        public LikeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Like GetLikeById(int likeId)
        {
            return _context.Likes.FirstOrDefault(l => l.LikeId == likeId);
        }

        public IEnumerable<Like> GetAllLikes()
        {
            return _context.Likes.ToList();
        }

        public IEnumerable<Like> GetLikesForPost(int postId)
        {
            return _context.Likes.Where(l => l.PostId == postId).ToList();
        }

        public IEnumerable<Like> GetLikesByUser(int userId)
        {
            return _context.Likes.Where(l => l.UserId == userId).ToList();
        }

        public void AddLike(Like like)
        {
            _context.Likes.Add(like);
            _context.SaveChanges();
        }

        public void RemoveLike(Like like)
        {
            _context.Likes.Remove(like);
            _context.SaveChanges();
        }
    }
}

