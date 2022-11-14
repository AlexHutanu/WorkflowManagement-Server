using Microsoft.AspNetCore.Mvc;
using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Controllers;

[ApiController]
[Route("[controller]")]

public class TicketsController : Controller
{
    private readonly IService<Ticket> _ticketsService;

    public TicketsController(IService<Ticket> ticketsService)
    {
        _ticketsService = ticketsService;
    }

    [HttpPost]
    public Ticket Index([FromBody] Ticket body)
    {
        Ticket newTicket = _ticketsService.Create(body);

        return newTicket;
    }

    [HttpGet("{ticketName}")]
    public ActionResult<Ticket> Index(string ticketName)
    {
        var ticket = _ticketsService.Find(ticketName);

        return ticket == null ? NotFound("Ticket not found") : ticket;
    }
}