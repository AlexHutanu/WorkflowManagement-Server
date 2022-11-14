using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;
using WorkflowManagement.Repositories;

namespace WorkflowManagement.Services;

public class BoardService : IService<Board>
{

    private BoardsRepository _boardsRepository;

    public BoardService()
    {
        var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        _boardsRepository = new BoardsRepository(new ApplicationDbContext(contextOptions));
    }
    public Board Create(Board data)
    {
        var board = _boardsRepository.Create(data);
        
        return board;
    }

    public Board Find(string name)
    {
        var board = _boardsRepository.FindOneByName(name);

        return board;
    }
    
}