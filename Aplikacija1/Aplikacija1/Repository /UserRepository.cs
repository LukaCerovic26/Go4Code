using System;
using Aplikacija1.Model;
using Aplikacija1.Repositories;

namespace Aplikacija1.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User GetUserById(int userId)
        {
            return _context.Users.FirstOrDefault(u => u.UserId == userId);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User AddUser(User user)
        {
            var NewUser = new User
            {
                UserName = user.UserName
        };

            _context.Users.Add(NewUser);
            _context.SaveChanges();
            return user;

        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }

}

