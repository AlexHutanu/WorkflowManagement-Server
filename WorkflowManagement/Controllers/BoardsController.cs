using Microsoft.AspNetCore.Mvc;
using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Controllers;

[ApiController]
[Route("[controller]")]
public class BoardsController : Controller
{

    private readonly IService<Board> _boardService;

    public BoardsController(IService<Board> boardService)
    {
        _boardService = boardService;
    }
    
    [HttpPost]
    public Board Index([FromBody] Board body)
    {
        Board newBoard = _boardService.Create(body);

        return newBoard;
    }

    [HttpGet("{boardName}")]
    public IEnumerable<Board> Index(string boardName)
    {
        var boards = _boardService.Find(boardName);

        return boards;
    }
}