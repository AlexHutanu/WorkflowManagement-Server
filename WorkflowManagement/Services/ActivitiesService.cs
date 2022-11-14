using System.Diagnostics;
using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;
using Activity = WorkflowManagement.Entities.Activity;

namespace WorkflowManagement.Services;

public class ActivitiesService : IService<Activity>
{

    public Activity Create(Activity data)
    {
        return new Activity
        {
            Owner = data.Owner,
            Description = data.Description,
            TimeCreated = data.TimeCreated
        };
    }

    public Activity Find(string name)
    {
        throw new NotImplementedException();
    }
    
    
}