using MediatR;

namespace WorkflowManagement.Commands;

public class CreateBugTicketCommand : IRequest<BugTicket>
{
    public BugTicket NewBugTicket { get; set; }
}