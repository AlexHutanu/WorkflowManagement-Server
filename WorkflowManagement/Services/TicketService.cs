using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;
using WorkflowManagement.Repositories;

namespace WorkflowManagement.Services;

public class TicketService : IService<Ticket>
{
    
    private TicketRepository _ticketRepository;

    public TicketService()
    {
        var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        _ticketRepository = new TicketRepository(new ApplicationDbContext(contextOptions));
    }

    public Ticket Create(Ticket data)
    {
        var ticket = _ticketRepository.Create(data);

        return ticket;
    }

    public Ticket Find(string name)
    {
        var ticket = _ticketRepository.FindOneByName(name);

        return ticket;
    }
}