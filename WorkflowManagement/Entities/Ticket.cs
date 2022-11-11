namespace WorkflowManagement.Entities;

public class Ticket
{
    [Key]
    public Guid Id { get; set; }
    
    [Column("Name", TypeName = "varchar(200)")]
    public string? Name { get; set; }
    
    [Column("Owner", TypeName = "varchar(200)")]
    public string? Owner { get; set; }
    
    [Column("Description", TypeName = "varchar(200)")]
    public string? Description { get; init; }
    
    [Column("Deadline", TypeName = "varchar(200)")]
    public double Deadline { get; set; }
}