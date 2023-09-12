using System;
using Aplikacija1.Model;

namespace Aplikacija1.Repository
{
	public interface ILikeRepository
	{
		Like GetLikeById(int likeid);
		IEnumerable<Like> GetAllLikes();
		void AddLike(Like like);
		void UpdateLike(Like like);
		void DeletePost(Like like);
	}
}

