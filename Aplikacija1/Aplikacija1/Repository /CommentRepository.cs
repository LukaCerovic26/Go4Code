using System;
using Aplikacija1.Model;
using Aplikacija1.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Aplikacija1.Repository
{

    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Comment> _collection;
    
        public CommentRepository(AppDbContext dbContext)
        {
            _context = dbContext;
            _collection = _context.Comments;
        }

        public async Task<Comment> Create(Comment comment)
        {
            comment.CreatedAt = DateTime.Now;

            await _collection.AddAsync(comment);
            await _context.SaveChangesAsync();

            return comment;
        }

        public async Task<Comment> Get(int id)
        {
            return await _collection.AsNoTracking().FirstOrDefaultAsync(post => post.Id == id);
        }

        public async Task<IEnumerable<Comment>> GetAll()
        {
            return await _collection.AsNoTracking().ToListAsync();
        }


        public async Task Delete(Comment comment)
        {
            _collection.Remove(comment);
            await _context.SaveChangesAsync();
        }
    }
}

