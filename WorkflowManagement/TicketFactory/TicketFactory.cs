namespace WorkflowManagement.TicketFactory;

public class TicketFactory
{
    public static ITicket GetTicket(string ticketType)
    {
        return ticketType switch
        {
            "BugTicket" => new BugTicket(),
            "TaskTicket" => new TaskTicket(),
            _ => throw new ArgumentOutOfRangeException(nameof(ticketType), ticketType, null)
        };
    }
}