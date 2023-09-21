using Aplikacija1.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Aplikacija1.Repositories
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Like> Likes { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        //public DbSet<Follow> Follows { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
