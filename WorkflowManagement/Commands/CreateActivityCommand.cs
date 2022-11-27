using MediatR;

namespace WorkflowManagement.Commands;

public class CreateActivityCommand : IRequest<Activity>
{
    public Activity NewActivity { get; set; }
}