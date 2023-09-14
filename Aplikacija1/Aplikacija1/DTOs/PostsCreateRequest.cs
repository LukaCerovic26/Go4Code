using System;
using System.ComponentModel.DataAnnotations;

namespace Aplikacija1.DTOs
{
	public class PostsCreateRequest
    {
        [Required]
        public string? Text { get; set; }
        [Required]
        public DateTime? CreatedAt { get; set; }
    }
}

