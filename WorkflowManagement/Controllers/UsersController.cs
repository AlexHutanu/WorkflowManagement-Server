using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkflowManagement.Commands;
using WorkflowManagement.Interfaces;
using WorkflowManagement.Queries;

namespace WorkflowManagement.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class UsersController : Controller
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromBody] User body)
        {
            var command = new CreateUserCommand() { NewUser = body };
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [Authorize]
        [HttpGet("username")]
        public async Task<IActionResult> Index(string userName)
        {
            var result = await _mediator.Send(new GetUserQuery(userName));

            return Ok(result);
        }

    }
}
