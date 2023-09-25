using System;
using Aplikacija1.DTOs;
using Aplikacija1.Model;

namespace Aplikacija1.Service
{
    public interface IUserService
    {

      
        public Task<UserGetDetailsResponse> GetDetailsAsync(String Id);
        ///RESIIIIIIIIIIIIIII
      
        public User GetUserById(String Id);
        IEnumerable<User> GetAllUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}

