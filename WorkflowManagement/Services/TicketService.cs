using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Services;

public class TicketService : ITicketsService<Ticket>
{
    public Ticket Create(Ticket data)
    {
        return new Ticket()
        {
            Name = data.Name,
            Owner = data.Owner,
            Description = data.Description,
            Deadline = data.Deadline
        };
    }
}