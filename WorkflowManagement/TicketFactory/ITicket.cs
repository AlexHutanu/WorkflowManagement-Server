namespace WorkflowManagement.TicketFactory;

public interface ITicket
{
    Guid Id { get; set; }
 
    string TicketType { get; set; }
    
    string? Name { get; set; }
    
    string? Asignee { get; set; }
    
    string? Reporter { get; set; }
    
    string? Description { get; set; }
    
    double Deadline { get; set; }
    
    string? Status { get; set; }
}