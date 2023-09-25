using System;
using Aplikacija1.Model;
using Aplikacija1.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacija1.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(IUserService userService, UserManager<IdentityUser> userManager)
        {
            _userService = userService;
            _userManager = userManager;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetUserById(String Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // NAPRAVI NAPRAVI AKCIJE ZA UPRAVLJANJE USERIMA (GetAllUsers, AddUser, UpdateUser, DeleteUser)
    }
}
