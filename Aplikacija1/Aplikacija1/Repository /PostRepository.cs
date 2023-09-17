using System;
using Aplikacija1.Model;
using Aplikacija1.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Aplikacija1.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _context;
        public readonly DbSet<Post> _collection;
       

        public PostRepository(AppDbContext dbContext)
        {
            _context = dbContext;
            _collection = _context.Posts;
        }


        public async Task<Post> Create(Post post)
        {
            post.CreatedAt = DateTime.Now;

            await _collection.AddAsync(post);
            await _context.SaveChangesAsync();

            return post;
        }

        public async Task<Post> Get(int id)
        {
            return await _collection.AsNoTracking().FirstOrDefaultAsync(post => post.Id == id);
        }

        public async Task<IEnumerable<Post>> GetAll()
        {
            return await _collection.AsNoTracking().ToListAsync();
        }


        public async Task Delete(Post post)
        {
            _collection.Remove(post);
            await _context.SaveChangesAsync();
        }
    }

}

