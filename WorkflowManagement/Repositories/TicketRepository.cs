using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Repositories;

public class TicketRepository : IRepository<Ticket>
{

    private ApplicationDbContext _context;

    public TicketRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Ticket Create(Ticket ticketData)
    {
        Ticket ticket = new()
        {
            Id = ticketData.Id,
            Name = ticketData.Name,
            Owner = ticketData.Owner,
            Description = ticketData.Description,
            Deadline = ticketData.Deadline
        };

        _context.Ticket.Add(ticket);
        _context.SaveChanges();

        return ticket;
    }

    public Ticket FindOneByName(string name)
    {
        return _context.Ticket.FirstOrDefault(ticket => ticket.Name == name);
    }

    public IEnumerable<Ticket> Find()
    {
        throw new NotImplementedException();
    }
}