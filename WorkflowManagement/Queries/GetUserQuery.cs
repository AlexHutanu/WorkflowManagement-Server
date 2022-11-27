using MediatR;

namespace WorkflowManagement.Queries;

public class GetUserQuery : IRequest<User>
{
    public string? Name { get; set; }

    public GetUserQuery(string name)
    {
        Name = name;
    }
}