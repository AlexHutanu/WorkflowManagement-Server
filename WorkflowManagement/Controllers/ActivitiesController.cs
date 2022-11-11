﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WorkflowManagement.Entities;
using WorkflowManagement.Interfaces;
using Activity = WorkflowManagement.Entities.Activity;

namespace WorkflowManagement.Controllers;


[Route("[controller]")]
[ApiController]

public class ActivitiesController : Controller
{

    private readonly IActivitiesService<Activity> _activitiesService;

    public ActivitiesController(IActivitiesService<Activity> activitiesService)
    {
        _activitiesService = activitiesService;
    }

    [HttpPost]
    public Activity Index([FromBody] Activity body)
    {
        Activity newActivity = _activitiesService.Create(body);

        return newActivity;
    }
    
}