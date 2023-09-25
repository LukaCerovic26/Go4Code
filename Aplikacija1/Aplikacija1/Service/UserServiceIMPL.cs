using System;
using Aplikacija1.DTOs;
using Aplikacija1.Model;
using Aplikacija1.Repository;
using AutoMapper;

namespace Aplikacija1.Service
{
    public class UserServiceIMPL : IUserService

	{
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserServiceIMPL(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<UserGetDetailsResponse> GetDetailsAsync(String Id)
        {
            var user = await _userRepository.GetUserById(Id);

            if (user == null)
            {
                return null;
            }
            return _mapper.Map<UserGetDetailsResponse>(user);
        }

        public User GetUserById(string Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

    }
}


