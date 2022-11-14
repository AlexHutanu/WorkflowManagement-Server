using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Services;

public class TicketService : IService<Ticket>
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

    public Ticket Find(string name)
    {
        throw new NotImplementedException();
    }
}