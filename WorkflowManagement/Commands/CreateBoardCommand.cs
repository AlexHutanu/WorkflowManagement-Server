using MediatR;

namespace WorkflowManagement.Commands;

public class CreateBoardCommand : IRequest<Board>
{
    public Board NewBoard { get; set; }
}