using Microsoft.AspNetCore.Mvc;
using NLLCOMMONAPI.Models;
using NLLCOMMONAPI.Data.Interfaces;
using NLLCOMMONAPI.Data.Models;

namespace NLLCOMMONAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("CheckQRLogin")]
        public async Task<IActionResult> CheckQRLogin([FromBody] MUser request)
        {
            if (string.IsNullOrWhiteSpace(request.UserName) || string.IsNullOrWhiteSpace(request.Password))
                return BadRequest("Username and Password are required.");

            var user = await _userService.CheckQRLoginAsync(request.UserName, request.Password);

            if (user == null)
                return Unauthorized("Invalid credentials.");

            return Ok(user);
        }
    }
}
