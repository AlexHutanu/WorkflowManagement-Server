using MediatR;

namespace WorkflowManagement.Queries;

public class GetAllBoardsQuery : IRequest<Board>
{
    public string? Name { get; }

    public GetAllBoardsQuery(string name)
    {
        Name = name;
    }
}