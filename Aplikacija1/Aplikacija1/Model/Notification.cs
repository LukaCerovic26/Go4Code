using System;
namespace Aplikacija1.Model
{
	public class Notification
	{
		public int Id { get; set; }
		public int PostId { get; set; }
		public String UserId { get; set; }
		public DateTime CreatedAt { get; set; }
		public string Text { get; set; }

	}
}

