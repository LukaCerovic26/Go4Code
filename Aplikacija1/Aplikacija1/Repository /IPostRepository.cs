using System;
using Aplikacija1.Model;

namespace Aplikacija1.Repository
{
    public interface IPostRepository
    {
        public Task<Post> Create(Post post);
        public Task<IEnumerable<Post>> GetAll();
        public Task<Post> Get(int id);
        public Task Delete(Post post);
    }

}

//public Post GetPostById(int postId)
//{
//    return _context.Posts.FirstOrDefault(p => p.PostId == postId);
//}

//public IEnumerable<Post> GetAllPosts()
//{
//    return _context.Posts.ToList();
//}

//public void AddPost(Post post)
//{
//    _context.Posts.Add(post);
//    _context.SaveChanges();
//}

//public void UpdatePost(Post post)
//{
//    _context.Posts.Update(post);
//    _context.SaveChanges();
//}

//public void DeletePost(Post post)
//{
//    _context.Posts.Remove(post);
//    _context.SaveChanges();
//}