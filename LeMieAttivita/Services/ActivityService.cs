using LeMieAttivita.Data;
using LeMieAttivita.Models;
using LeMieAttivita.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMieAttivita.Services
{
    public class ActivityService
    {
        private readonly LeMieAttivitaContext _context;
        private readonly ApiTokenService _apiTokenService;
        private readonly AthleteService _athleteService;

        private const string URL = "https://www.strava.com/api/v3/athlete/activities";

        public ActivityService(LeMieAttivitaContext context, ApiTokenService apiTokenService, AthleteService athleteService)
        {
            _context = context;
            _apiTokenService = apiTokenService;
            _athleteService = athleteService;
        }

        public List<Activity> RetrieveActivitiesFromStrava()
        {
            ApiToken apiToken = _apiTokenService.FindAll().FirstOrDefault();

            // Building the request object
            RestClient client = new RestClient(URL);
            RestRequest request = new RestRequest();
            request.Method = Method.GET;
            request.AddHeader("Authorization", "Bearer " + apiToken.AccessToken);

            // Executing the request
            IRestResponse response = client.Execute<Athlete>(request);

            // Deserializing the response into an Athlete object
            List<Activity> activities = JsonConvert.DeserializeObject<List<Activity>>(response.Content);

            InsertAll(activities);
            return activities;
        }

        public void InsertAll(List<Activity> newActivities)
        {
            List<Activity> oldActivities = FindAll();
            Athlete athlete = _athleteService.FindByUsername();

            if (oldActivities == null || oldActivities.Count == 0)
            {
                foreach (Activity act01 in newActivities)
                {
                    act01.AthleteId = athlete.Id;
                    Insert(act01); 
                }
            }
            else
            {
                bool exists = false;

                foreach (Activity act01 in newActivities)
                {
                    foreach (Activity act02 in oldActivities)
                    {
                        if (act01.Id != act02.Id)
                        {
                            continue;
                        }
                        else
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        act01.AthleteId = athlete.Id;
                        Insert(act01);
                        exists = false;
                    }
                }
            }
        }

        public List<Activity> FindAll()
        {
            return _context.Activity.Include(a => a.Athlete).ToList();
        }

        public void Insert(Activity activity)
        {
            try
            {
                _context.Add(activity);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new DbConcurrencyException("Problems inserting the activity to the database. " + e.Message);
            }
        }
    }
}
