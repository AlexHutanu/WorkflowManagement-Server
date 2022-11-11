using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Services;

public class BoardService : IService<Board>
{
    public Board Create(Board data)
    {
        return new Board
        {
            Name = data.Name,
            Owner = data.Owner,
            Description = data.Description,
            NoOfTickets = data.NoOfTickets
        };
    }

    public IEnumerable<Board> Find(string name)
    {
        var board1 = new Board
        {
            Name = $"{name}1",
            Owner = "Owner1",
            Description = "Descript1",
            NoOfTickets = 1
        };
        
        var board2 = new Board
        {
            Name = $"{name}2",
            Owner = "Owner2",
            Description = "Descript2",
            NoOfTickets = 2
        };

        return new List<Board> { board1, board2 };
    }
}