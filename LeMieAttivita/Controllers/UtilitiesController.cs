using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeMieAttivita.Data;
using LeMieAttivita.Models;
using LeMieAttivita.Services;
using LeMieAttivita.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace LeMieAttivita.Controllers
{
    public class UtilitiesController : Controller
    {
        private readonly ApiTokenService _apiTokenService;
        private readonly StravaApiService _stravaApiService;
        private readonly AthleteService _athleteService;
        

        public UtilitiesController(ApiTokenService apiTokenService, StravaApiService stravaApiService, AthleteService athleteService)
        {
            _stravaApiService = stravaApiService;
            _apiTokenService = apiTokenService;
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

        public IActionResult GenerateNewAccessToken(string id)
        {
            string refreshToken = id;
            try
            {
                _stravaApiService.GenerateNewAccessToken(refreshToken);
                ViewData["AccessToken"] = "Access Token Was Refreshed";
                return RedirectToAction(nameof(Index));
            }
            catch (AccessTokenNotRefreshed)
            {
                return RedirectToAction(nameof(Error), new { message = "Access Token Could Not Be Refreshed." });
            }
        }

        public IActionResult Error(string message)
        {
            ViewData["ErrorMessage"] = message;
            return View();
        }
    }
}