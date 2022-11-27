using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorkflowManagement.Attributes;
using WorkflowManagement.Commands;
using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;
using WorkflowManagement.Queries;
using WorkflowManagement.Services;
using ILogger = WorkflowManagement.Interfaces.ILogger;
using LoggerFactory = WorkflowManagement.Services.LoggerFactory;

namespace WorkflowManagement.Controllers;

[ApiController]
[Route("[controller]")]

public class BugTicketsController : Controller
{
    private readonly IMediator _mediator;


    public BugTicketsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Index([FromBody] BugTicket body)
    {
        var command = new CreateBugTicketCommand() { NewBugTicket = body };
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet("{ticketName}")]
    [Log("getTicket")]
    public async Task<IActionResult> Index(string ticketName)
    {
        var result = await _mediator.Send(new GetBugTicketQuery(ticketName));

        return Ok(result);
    }
}