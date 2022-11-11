namespace WorkflowManagement.Entities;

public class Activity
{
    [Key]
    public Guid Id { get; set; }
    
    [Column("Description", TypeName = "varchar(200)")]
    public string? Description { get; set; }
    
    [Column("Owner", TypeName = "varchar(200)")]
    public string? Owner { get; set; }
    
    [Column("TimeCreated", TypeName = "varchar(200)")]
    public DateTime TimeCreated { get; set; }
}