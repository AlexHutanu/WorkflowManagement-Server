using MediatR;

namespace WorkflowManagement.Commands;

public class CreateUserCommand : IRequest<User>
{
    public User NewUser { get; set; }
}