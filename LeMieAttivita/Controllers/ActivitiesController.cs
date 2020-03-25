using LeMieAttivita.Data;
using LeMieAttivita.Services;
using Microsoft.AspNetCore.Mvc;
using LeMieAttivita.Services.Exceptions;
using System.Collections.Generic;
using LeMieAttivita.Models;

namespace LeMieAttivita.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly ActivityService _activityService;

        public ActivitiesController(ActivityService activityService)
        {
            _activityService = activityService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Retrieve()
        {
            List<Activity> activities = _activityService.RetrieveActivitiesFromStrava();
            return View(nameof(Index), activities);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Error(string message)
        {
            ViewData["ErrorMessage"] = message;
            return View();
        }
        
    }
}