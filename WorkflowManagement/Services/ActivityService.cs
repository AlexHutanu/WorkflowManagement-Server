using System.Diagnostics;
using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;
using WorkflowManagement.Repositories;
using Activity = WorkflowManagement.Entities.Activity;

namespace WorkflowManagement.Services;

public class ActivitiesService : IService<Activity>
{

    private ActivityRepository _activityRepository;

    public ActivitiesService()
    {
        var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        _activityRepository = new ActivityRepository(new ApplicationDbContext(contextOptions));
    }

    public Activity Create(Activity data)
    {
        return _activityRepository.Create(data);
        
    }

    public Activity Find(string name)
    {
        return _activityRepository.FindOneByName(name);
        
    }
    
    
}