using System;
using Aplikacija1.Model;

namespace Aplikacija1.Service
{
    public interface ICommentService
    {
        Comment GetCommentById(int commentId);
        IEnumerable<Comment> GetAllComments();
        void AddComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(Comment comment);
    }
}

