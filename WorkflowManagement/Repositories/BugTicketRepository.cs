using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Repositories;

public class BugTicketRepository : IRepository<BugTicket>
{

    private ApplicationDbContext _context;

    public BugTicketRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public BugTicket Create(BugTicket ticketData)
    {
        BugTicket ticket = new()
        {
            Id = ticketData.Id,
            Name = ticketData.Name,
            Asignee = ticketData.Asignee,
            Reporter = ticketData.Reporter,
            Description = ticketData.Description,
            Deadline = ticketData.Deadline,
            Status = ticketData.Status,
            StepsToReproduce = ticketData.StepsToReproduce,
            ExpectedResult = ticketData.ExpectedResult,
            ActualResult = ticketData.ActualResult
        };

        _context.BugTicket.Add(ticket);
        _context.SaveChanges();

        return ticket;
    }

    public BugTicket FindOneByName(string name)
    {
        return _context.BugTicket.FirstOrDefault(ticket => ticket.Name == name);
    }

    public IEnumerable<BugTicket> Find()
    {
        throw new NotImplementedException();
    }
}