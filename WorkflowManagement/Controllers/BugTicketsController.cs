using Microsoft.AspNetCore.Mvc;
using WorkflowManagement.Attributes;
using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;
using WorkflowManagement.Services;
using ILogger = WorkflowManagement.Interfaces.ILogger;
using LoggerFactory = WorkflowManagement.Services.LoggerFactory;

namespace WorkflowManagement.Controllers;

[ApiController]
[Route("[controller]")]

public class BugTicketsController : Controller
{
    private readonly IService<BugTicket> _bugTicketsService;


    public BugTicketsController(IService<BugTicket> bugTicketsService)
    {
        _bugTicketsService = bugTicketsService;
    }

    [HttpPost]
    public BugTicket Index([FromBody] BugTicket body)
    {
        BugTicket newBugTicket = _bugTicketsService.Create(body);

        return newBugTicket;
    }

    [HttpGet("{ticketName}")]
    [Log("getTicket")]
    public ActionResult<Ticket> Index(string ticketName)
    {
        var logger = LoggerFactory.GetLogger();
        
        logger.Error("error");
        logger.Info("info");
        
        var ticket = _bugTicketsService.Find(ticketName);
        
        return ticket == null ? NotFound("Ticket not found") : ticket;
    }
}