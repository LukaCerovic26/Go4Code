using Aplikacija1.Model;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Aplikacija1.Model
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Post> Posts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}





//public class ApplicationDbContext : IdentityDbContext<IdentityUser>
//{
//    public DbSet<User> Users { get; set; }
//    public DbSet<Post> Posts { get; set; }
//    public DbSet<Comment> Comments { get; set; }
//    public DbSet<Like> Likes { get; set; }

//    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
//}




//public class ApplicationDbContext : DbContext
//{
//    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//        : base(options)
//    {
//    }

//    public DbSet<User> Users { get; set; }
//    public DbSet<Post> Posts { get; set; }
//    public DbSet<Comment> Comments { get; set; }
//    public DbSet<Like> Likes { get; set; }

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        // KONFIG ZA ODNOS 
//        modelBuilder.Entity<User>()
//            .HasMany(u => u.Posts)
//            .WithOne(p => p.User)
//            .HasForeignKey(p => p.UserId);

//        modelBuilder.Entity<Post>()
//            .HasMany(p => p.Comments)
//            .WithOne(c => c.Post)
//            .HasForeignKey(c => c.PostId);

//        modelBuilder.Entity<Post>()
//            .HasMany(p => p.Likes)
//            .WithOne(l => l.Post)
//            .HasForeignKey(l => l.PostId);
//    }

//}



