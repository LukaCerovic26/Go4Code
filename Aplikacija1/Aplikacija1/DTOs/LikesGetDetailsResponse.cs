using System;
using Aplikacija1.Model;

namespace Aplikacija1.DTOs
{
	public class LikesGetDetailsResponse
	{
        public int LikeId { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

