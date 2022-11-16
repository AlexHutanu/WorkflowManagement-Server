using Microsoft.AspNetCore.Mvc;
using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Controllers
{
    public class UsersController : Controller
    {
        private readonly IService<User> _userService;

        public UsersController(IService<User> userService)
        {
            _userService= userService; 
        }

        [HttpPost]
        public User Index([FromBody] User body)
        {
            User newUser = _userService.Create(body);

            return newUser;
        }

        [HttpGet]
        public ActionResult<User> Index(string username)
        {
            var user = _userService.Find(username);

            return user == null ? NotFound("User not found") : user;
        }

    }
}
