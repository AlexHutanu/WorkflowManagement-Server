using MediatR;
using WorkflowManagement.Queries;

namespace WorkflowManagement.Handlers;

public class GetAllBoardsQueryHandler : IRequestHandler<GetAllBoardsQuery, Board>
{
    private readonly ApplicationDbContext _context;

    public GetAllBoardsQueryHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Board> Handle(GetAllBoardsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Boards.FirstAsync(board => board.Name == request.Name);
    }
}