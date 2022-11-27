using System.Diagnostics;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorkflowManagement.Commands;
using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;
using WorkflowManagement.Queries;
using Activity = WorkflowManagement.Entities.Activity;

namespace WorkflowManagement.Controllers;


[Route("[controller]")]
[ApiController]

public class ActivitiesController : Controller
{

    private readonly IMediator _mediator;

    public ActivitiesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Index([FromBody] Activity body)
    {
        var command = new CreateActivityCommand() { NewActivity = body };
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet("{activityName}")]
    public async Task<IActionResult> Index(string activityName)
    {

        var result = await _mediator.Send(new GetActivityQuery(activityName));

        return Ok(result);
    }

}