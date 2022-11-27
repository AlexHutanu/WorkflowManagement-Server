using MediatR;

namespace WorkflowManagement.Queries;

public class GetActivityQuery : IRequest<Activity>
{
    public string? Name { get; }

    public GetActivityQuery(string name)
    {
        Name = name;
    }
}