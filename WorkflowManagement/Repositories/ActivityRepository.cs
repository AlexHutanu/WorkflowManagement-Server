using WorkflowManagement.Interfaces;

namespace WorkflowManagement.Repositories;

public class ActivityRepository : IRepository<Activity>
{

    private ApplicationDbContext _context;


    public ActivityRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Activity Create(Activity activityData)
    {
        Activity activity = new()
        {
            Id = activityData.Id,
            Name = activityData.Name,
            Description = activityData.Description,
            Owner = activityData.Owner,
            TimeCreated = activityData.TimeCreated
        };

        _context.Activity.Add(activity);
        _context.SaveChanges();

        return activity;
    }

    public Activity FindOneByName(string name)
    {
        return _context.Activity.FirstOrDefault(activity => activity.Name == name);
    }

    public IEnumerable<Activity> Find()
    {
        throw new NotImplementedException();
    }
}