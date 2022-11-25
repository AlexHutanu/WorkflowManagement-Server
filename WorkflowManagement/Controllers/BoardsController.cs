using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using WorkflowManagement.Commands;
using WorkflowManagement.Interfaces;
using WorkflowManagement.Queries;

namespace WorkflowManagement.Controllers;

[ApiController]
[Route("[controller]")]
[DefaultStatusCode(200)]
public class BoardsController : Controller
{

    private readonly IService<Board> _boardService;
    private readonly IMediator _mediator;

    public BoardsController(IService<Board> boardService, IMediator mediator)
    {
        _boardService = boardService;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Index([FromBody] Board body)
    {
        // Board newBoard = _boardService.Create(body);

        // return newBoard;

        var command = new CreateBoardCommand() { NewBoard = body };
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet("{boardName}")]
    public async  Task<ActionResult<Board>> Index(string boardName)
    {
        // var board = _boardService.Find(boardName);

        var result = await _mediator.Send(new GetAllBoardsQuery(boardName));

        // return board == null ? NotFound("Board not found") : board;

        return Ok(result);
    }
}