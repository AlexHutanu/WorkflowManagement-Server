namespace WorkflowManagement.TicketFactory;

public class TaskTicket : ITicket
{
    public Guid Id { get; set; }

    public string TicketType { get; set; } = "TaskTicket";
    
    public string? Name { get; set; }
    
    public string? Asignee { get; set; }
    
    public string? Reporter { get; set; }
    
    public string? Description { get; set; }
    
    public double Deadline { get; set; }
    
    public string? Status { get; set; }
}