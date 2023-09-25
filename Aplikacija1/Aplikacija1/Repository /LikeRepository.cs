using System;
using Aplikacija1.Model;
using Aplikacija1.Repositories;
using Aplikacija1.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Aplikacija1.Repository
{
    public class LikeRepository : ILikeRepository
    {
        private readonly AppDbContext _context;
        public readonly DbSet<Like> _collection;

        public LikeRepository(AppDbContext dbContext)
        {
            _context = dbContext;
            _collection = _context.Likes;
        }

        public async Task<Like> Create(Like like)
        {
            like.CreatedAt = DateTime.Now;

            await _collection.AddAsync(like);
            await _context.SaveChangesAsync();

            return like;
        }

        public async Task<Like> Get(int id)
        {
            return await _collection.AsNoTracking().FirstOrDefaultAsync(like => like.Id == id);
        }

        public async Task<IEnumerable<Like>> GetAll()
        {
            return await _collection.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Like>> GetLikesForPost(int postId)
        {
            
            return await _collection.AsNoTracking().Where(like => like.PostId == postId).ToListAsync();

        }

        public async Task<IEnumerable<Like>> GetLikesByUser(String userId)
        {
            return await _collection.AsNoTracking().Where(like => like.UserId == userId).ToListAsync();
        }

        public async Task Delete(Like like)
        {
            _collection.Remove(like);
            await _context.SaveChangesAsync();
        }

        public async Task<int> GetLikesCountForPost(int postId)
        {
            return await _collection.AsNoTracking().Where(like => like.PostId == postId).CountAsync();
        }
        ///FORMATIRANJE UBACI AKO TREBA 
    }
}

