using System;
using System.ComponentModel.DataAnnotations;
using Aplikacija1.Model;

namespace Aplikacija1.DTOs
{
    public class LikesCreateRequest
    {

        [Required]
        public String UserId { get; set; }
        [Required]
        public int PostId { get; set; }

    }
    public class LikesDeleteRequest
    {
        [Required]
        public String UserId { get; set; }
        [Required]
        public int PostId { get; set; }
    }
}

