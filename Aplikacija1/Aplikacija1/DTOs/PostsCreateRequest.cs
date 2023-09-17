using System;
using System.ComponentModel.DataAnnotations;
using Aplikacija1.Model;

namespace Aplikacija1.DTOs
{
	public class PostsCreateRequest
    {
        [Required]
        public string Text { get; set; }
        [Required]
        public int UserId { get; set; }

    }
}