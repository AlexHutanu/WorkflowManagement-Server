using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Services;

public class BoardService : IService<Board>
{
    public Board Create(Board data)
    {
        var board = new Board
        {
            Name = data.Name,
            Owner = data.Owner,
            Description = data.Description,
            NoOfTickets = data.NoOfTickets
        };

        var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        using var context = new ApplicationDbContext(contextOptions);

        context.Boards.Add(board);
        context.SaveChanges();


        return board;
    }

    public Board Find(string name)
    {
        var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        using var context = new ApplicationDbContext(contextOptions);

        var boards = context.Boards.Where(board => board.Name == name).FirstOrDefault<Board>();

        return boards;
    }
}