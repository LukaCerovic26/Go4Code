using System;
using Aplikacija1.Model;

namespace Aplikacija1.Repository
{
	public interface ICommentRepository
	{
		public Task<Comment> Create(Comment comment);
		public Task<IEnumerable<Comment>> GetAll();
		public Task<Comment> Get(int id);
		public Task Delete(Comment comment);
	}
}

