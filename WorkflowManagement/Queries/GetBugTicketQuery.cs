using MediatR;

namespace WorkflowManagement.Queries;

public class GetBugTicketQuery : IRequest<BugTicket>
{
    public string? Name { get; }

    public GetBugTicketQuery(string name)
    {
        Name = name;
    }
}