using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;
using WorkflowManagement.Repositories;

namespace WorkflowManagement.Services;

public class BugTicketService : IService<BugTicket>
{
    
    private BugTicketRepository _bugTicketRepository;

    public BugTicketService()
    {
        var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        _bugTicketRepository = new BugTicketRepository(new ApplicationDbContext(contextOptions));
    }

    public BugTicket Create(BugTicket data)
    {
        var ticket = _bugTicketRepository.Create(data);

        return ticket;
    }

    public BugTicket Find(string name)
    {
        var ticket = _bugTicketRepository.FindOneByName(name);

        return ticket;
    }
}