using System;
using Aplikacija1.Model;

namespace Aplikacija1.DTOs
{
	public class PostsGetDetailsResponse
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Userid { get; set; }
        public User User { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Like>? Likes { get; set; }
    }
}
