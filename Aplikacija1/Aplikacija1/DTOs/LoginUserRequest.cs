using System;
using System.ComponentModel.DataAnnotations;

namespace Aplikacija1.DTOs
{
    public class LoginUserRequest
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}

