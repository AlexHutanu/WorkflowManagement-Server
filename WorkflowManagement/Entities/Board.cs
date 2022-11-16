using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WorkflowManagement.Entities;

public class Board
{
    [Key]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Name field is required")]
    [StringLength(maximumLength: 100, MinimumLength = 2)]
    [Column("OwnerName", TypeName = "varchar(200)")]
    public string? Owner { get; set; }

    [Column("Description", TypeName = "varchar(200)")]
    public string? Description { get; set; }

    [Column("NoOfTickets", TypeName = "varchar(200)")]
    public int NoOfTickets { get; set; }
}