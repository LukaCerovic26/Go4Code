using System;
using Aplikacija1.Model;
using Aplikacija1.Repositories;

namespace Aplikacija1.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _context;

        public CommentRepository(AppDbContext context)
        {
            _context = context;
        }

        public Comment GetCommentById(int commentId)
        {
            return _context.Comments.FirstOrDefault(c => c.CommentId == commentId);
        }

        public IEnumerable<Comment> GetAllComments()
        {
            return _context.Comments.ToList();
        }

        public void AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public void UpdateComment(Comment comment)
        {
            _context.Comments.Update(comment);
            _context.SaveChanges();
        }

        public void DeleteComment(Comment comment)
        {
            _context.Comments.Remove(comment);
            _context.SaveChanges();
        }
    }
}

