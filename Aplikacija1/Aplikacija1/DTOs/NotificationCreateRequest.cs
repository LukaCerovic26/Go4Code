using System;
using System.ComponentModel.DataAnnotations;

namespace Aplikacija1.DTOs
{
	public class NotificationCreateRequest
	{
		[Required]
		public int UserId { get; set; }

		[Required]
		public int PostId { get; set; }
	}
    public class NotificationDeleteRequest
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int PostId { get; set; }
    }
}

