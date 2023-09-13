using System;
using Aplikacija1.Model;
using Aplikacija1.Repository;

namespace Aplikacija1.Service
{
	public class UserServiceIMPL
	{
        public class UserService
        {
            private readonly IUserRepository _userRepository;

            public UserService(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            // Poslovna logika 

            public User GetUserById(int userId)
            {
                return _userRepository.GetUserById(userId);
            }

            public IEnumerable<User> GetAllUsers()
            {
                return _userRepository.GetAllUsers();
            }

            public void AddUser(User user)
            {
                _userRepository.AddUser(user);
            }

            public void UpdateUser(User user)
            {
                _userRepository.UpdateUser(user);
            }

            public void DeleteUser(User user)
            {
                _userRepository.DeleteUser(user);
            }
        }
    }
}


