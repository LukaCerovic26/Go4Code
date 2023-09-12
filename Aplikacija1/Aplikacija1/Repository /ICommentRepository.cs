using System;
using Aplikacija1.Model;

namespace Aplikacija1.Repository
{
	public interface ICommentRepository
	{
		Comment GetCommentById(int commentid);
		IEnumerable<Comment> GetAllComments();
		void AddComment(Comment comment);
		void UpdateComment(Comment comment);
		void DeleteComment(Comment comment);
	}
}

