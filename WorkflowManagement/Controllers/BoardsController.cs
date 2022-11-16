﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Controllers;

[ApiController]
[Route("[controller]")]
[DefaultStatusCode(200)]
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
    public ActionResult<Board> Index(string boardName)
    {
        var board = _boardService.Find(boardName);

        return board == null ? NotFound("Board not found") : board;
    }
}