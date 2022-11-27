using MediatR;
using WorkflowManagement.Queries;

namespace WorkflowManagement.Handlers.ActivityHandler;

public class GetActivityQueryHandler : IRequestHandler<GetActivityQuery, Activity>
{

    private readonly ApplicationDbContext _context;

    public GetActivityQueryHandler(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<Activity> Handle(GetActivityQuery request, CancellationToken cancellationToken)
    {
        return await _context.Activity.FirstAsync(activity => activity.Name == request.Name, cancellationToken: cancellationToken);
    }
}