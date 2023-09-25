using System;
using Aplikacija1.Model;

namespace Aplikacija1.Repository
{
    public interface IUserRepository
    {
        public Task<User> GetUserById(String Id);
        IEnumerable<User> GetAllUsers();
        User AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}

