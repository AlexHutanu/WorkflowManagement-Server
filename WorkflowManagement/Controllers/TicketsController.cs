using Microsoft.AspNetCore.Mvc;
using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Controllers;

[ApiController]
[Route("[controller]")]

public class TicketsController : Controller
{
    private readonly ITicketsService<Ticket> _ticketsService;

    public TicketsController(ITicketsService<Ticket> ticketsService)
    {
        _ticketsService = ticketsService;
    }

    [HttpPost]
    public Ticket Index([FromBody] Ticket body)
    {
        Ticket newTicket = _ticketsService.Create(body);

        return newTicket;
    }
}