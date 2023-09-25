using System;
namespace Aplikacija1.Model
{
    public class Like
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public DateTime CreatedAt { get; set; }
        public String UserId { get; set; }
    }
}

