using System;
using System.ComponentModel.DataAnnotations;

namespace Aplikacija1.DTOs
{
	public class CommentsCreateRequest
    {
        [Required]
        public string? Text { get; set; }
        [Required]
        public DateTime? CreatedAt { get; set; }
    }
}

