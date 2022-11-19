using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class UsersController : Controller
    {
        private readonly IService<User> _userService;

        public UsersController(IService<User> userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public User Index([FromBody] User body)
        {
            User newUser = _userService.Create(body);

            return newUser;
        }

        [Authorize]
        [HttpGet("username")]
        public async Task<ActionResult<User>> Index()
        {
            var username = HttpContext.User.Identity.Name;

            var user = _userService.Find(username);

            if (user == null)
                NotFound("User not found");

            return user;
        }

    }
}
