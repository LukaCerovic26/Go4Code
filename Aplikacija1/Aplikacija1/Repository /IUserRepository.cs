using System;
using Aplikacija1.Model;

namespace Aplikacija1.Repository
{
    public interface IUserRepository
    {
        User GetUserById(int userId);
        IEnumerable<User> GetAllUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}

