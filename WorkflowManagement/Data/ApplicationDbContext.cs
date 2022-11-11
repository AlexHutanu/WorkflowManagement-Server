
namespace WorkflowManagement.Data;

public class ApplicationDbContext : DbContext
{
    
    protected readonly IConfiguration Configuration;
    
    public ApplicationDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(Configuration.GetConnectionString("ConnectionString"));
    }

    public DbSet<Board> Boards { get; set; }
    public DbSet<Ticket> Ticket { get; set; }
    public DbSet<Activity> Activity { get; set; }
}

