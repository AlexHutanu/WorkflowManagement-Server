using System.Diagnostics;
using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;
using Activity = WorkflowManagement.Entities.Activity;

namespace WorkflowManagement.Services;

public class ActivitiesService : IActivitiesService<Activity>
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
    
}