using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeMieAttivita.Data;
using LeMieAttivita.Models;
using LeMieAttivita.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using RestSharp;

namespace LeMieAttivita.Services
{
    public class AthleteService
    {
        private readonly LeMieAttivitaContext _context;
        private readonly ApiTokenService _apiTokenService;

        private const string USERNAME = "rsoliveira2018";

        private const string URL = "https://www.strava.com/api/v3/athlete";

        public AthleteService(LeMieAttivitaContext context, ApiTokenService apiTokenService)
        {
            _context = context;
            _apiTokenService = apiTokenService;
        }

        public void Insert(Athlete athlete)
        {
            try
            {
                _context.Add(athlete);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new DbConcurrencyException("Problems inserting the athlete to the database.");
            }
        }

        public Athlete FindById(int? athleteId)
        {
            if(athleteId == null)
                throw new NotFoundException("Athlete id was not provided.");

            if (!_context.Athlete.Any(athlete => athlete.Id == athleteId))
                throw new NotFoundException("There is no Athlete in the database with the provided Id.");

            return _context.Athlete.Include(a => a.ApiToken).Where(a => a.Id == athleteId).FirstOrDefault();
        }

        public Athlete RetrieveAthleteFromStrava()
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
            Athlete athlete = JsonConvert.DeserializeObject<Athlete>(response.Content);

            athlete.ApiToken = apiToken;
            athlete.ApiTokenId = apiToken.Id;

            return athlete;
        }

        public void Edit()
        {
            Athlete athlete = RetrieveAthleteFromStrava();
            _context.Update(athlete);
            _context.SaveChanges();
        }

        public List<Athlete> FindAll()
        {
            return _context.Athlete.Include(a => a.ApiToken).ToList();
        }

        public Athlete FindByUsername()
        {
            return _context.Athlete.Include(a => a.ApiToken).Where(a => a.Username == USERNAME).FirstOrDefault();
        }
    }
}
