using System;
using Aplikacija1.Model;
using Aplikacija1.Repository;

namespace Aplikacija1.Service
{
    public class CommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        // POSOVNA LOGIKA

        public Comment GetCommentById(int commentId)
        {
            return _commentRepository.GetCommentById(commentId);
        }

        public IEnumerable<Comment> GetAllComments()
        {
            return _commentRepository.GetAllComments();
        }

        public void AddComment(Comment comment)
        {
            _commentRepository.AddComment(comment);
        }

        public void UpdateComment(Comment comment)
        {
            _commentRepository.UpdateComment(comment);
        }

        public void DeleteComment(Comment comment)
        {
            _commentRepository.DeleteComment(comment);
        }
    }
}

