using LeMieAttivita.Models;
using LeMieAttivita.Services;
using LeMieAttivita.Data;
using Microsoft.AspNetCore.Mvc;
using LeMieAttivita.Services.Exceptions;
using System;
using MySql.Data.MySqlClient;

namespace LeMieAttivita.Controllers
{
    public class AthletesController : Controller
    {
        private readonly AthleteService _athleteService;

        public AthletesController(AthleteService athleteService)
        {
            _athleteService = athleteService;
        }

        public IActionResult Index()
        {
            try
            {
                Athlete athlete = _athleteService.FindByUsername();
                return View(athlete);
            }
            catch (MySqlException)
            {
                return RedirectToAction(nameof(Error), new { message = "Error while trying to access the database." });
            }
        }

        [HttpGet]
        public IActionResult Edit()
        {
            try
            {
                _athleteService.Edit();
                return RedirectToAction(nameof(Index));
            }
            catch (MySqlException)
            {
                return RedirectToAction(nameof(Error), new { message = "Error while trying to access the database for editing." });
            }
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