using System;
using Aplikacija1.Model;
using Aplikacija1.Service;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacija1.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{userId}")]
        public ActionResult<User> GetUserById(int userId)
        {
            var user = _userService.GetUserById(userId);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // NAPRAVI NAPRAVI AKCIJE ZA UPRAVLJANJE USERIMA (GetAllUsers, AddUser, UpdateUser, DeleteUser)
    }
}
