using System;
using Aplikacija1.Model;

namespace Aplikacija1.DTOs
{
	public class CommentsGetDetailsResponse
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}


