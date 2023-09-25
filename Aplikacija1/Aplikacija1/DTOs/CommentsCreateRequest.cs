using System;
using System.ComponentModel.DataAnnotations;

namespace Aplikacija1.DTOs
{
	public class CommentsCreateRequest
    {
        [Required]
        public string? Text { get; set; }
        [Required]
        public String UserId { get; set; }
        [Required]
        public int PostId { get; set; }
    }
}

