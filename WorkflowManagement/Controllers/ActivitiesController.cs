using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;
using Activity = WorkflowManagement.Entities.Activity;

namespace WorkflowManagement.Controllers;


[Route("[controller]")]
[ApiController]

public class ActivitiesController : Controller
{

    private readonly IService<Activity> _activitiesService;

    public ActivitiesController(IService<Activity> activitiesService)
    {
        _activitiesService = activitiesService;
    }

    [HttpPost]
    public Activity Index([FromBody] Activity body)
    {
        Activity newActivity = _activitiesService.Create(body);

        return newActivity;
    }

    [HttpGet("{activityName}")]
    public ActionResult<Activity> Index(string activityName)

    {
        var activity = _activitiesService.Find(activityName);

        return activity == null ? NotFound("Activity not found") : activity;
    }

}