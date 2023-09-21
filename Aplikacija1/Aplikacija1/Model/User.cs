using System;
namespace Aplikacija1.Model
{
	public class User
    {
		
        public int UserId { get; set; }
        public string UserName { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<User> FollowedUsers { get; set; }
    }
}


