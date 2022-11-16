using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Repositories;

public class BoardsRepository : IRepository<Board>
{
    private ApplicationDbContext _context;

    public BoardsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Board Create(Board boardData)
    {
        Board board = new()
        {
            Name = boardData.Name,
            Owner = boardData.Owner,
            Description = boardData.Description,
            NoOfTickets = boardData.NoOfTickets
        };

        _context.Boards.Add(board);
        _context.SaveChanges();

        return board;
    }

    public Board FindOneByName(string name)
    {
        return _context.Boards.FirstOrDefault(board => board.Name == name);

    }

    public IEnumerable<Board> Find()
    {
        throw new NotImplementedException();
    }
}