using MediatR;
using WorkflowManagement.Queries;

namespace WorkflowManagement.Handlers;

public class GetBoardQueryHandler : IRequestHandler<GetBoardQuery, Board>
{
    private readonly ApplicationDbContext _context;

    public GetBoardQueryHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Board> Handle(GetBoardQuery request, CancellationToken cancellationToken)
    {
        return await _context.Boards.FirstAsync(board => board.Name == request.Name);
    }
}