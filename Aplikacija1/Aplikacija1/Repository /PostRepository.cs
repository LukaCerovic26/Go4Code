using System;
using Aplikacija1.Model;
using Aplikacija1.Repositories;

namespace Aplikacija1.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _context;

        public PostRepository(AppDbContext context)
        {
            _context = context;
        }

        public Post GetPostById(int postId)
        {
            return _context.Posts.FirstOrDefault(p => p.PostId == postId);
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _context.Posts.ToList();
        }

        public void AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        public void UpdatePost(Post post)
        {
            _context.Posts.Update(post);
            _context.SaveChanges();
        }

        public void DeletePost(Post post)
        {
            _context.Posts.Remove(post);
            _context.SaveChanges();
        }
    }

}

