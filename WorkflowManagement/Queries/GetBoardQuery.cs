using MediatR;

namespace WorkflowManagement.Queries;

public class GetBoardQuery : IRequest<Board>
{
    public string? Name { get; }

    public GetBoardQuery(string name)
    {
        Name = name;
    }
}