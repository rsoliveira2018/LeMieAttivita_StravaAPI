using LeMieAttivita.Data;
using LeMieAttivita.Models;
using LeMieAttivita.Services;
using LeMieAttivita.Services.Exceptions;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LeMieAttivita.Services
{
    public class StravaApiService
    {
        private const string TOKEN_URL = "https://www.strava.com/api/v3/oauth/token"; 
        private readonly ApiTokenService _apiTokenService;

        public StravaApiService(ApiTokenService apiTokenService)
        {
            _apiTokenService = apiTokenService;
        }

        public void GenerateNewAccessToken(string refreshToken)
        {
            // Recover the Api Token
            ApiToken currentApiToken = _apiTokenService.FindByRefreshToken(refreshToken);

            // Build the Request Object
            RestClient client = new RestClient(TOKEN_URL);
            RestRequest request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("grant_type", "refresh_token");
            request.AddHeader("client_id", currentApiToken.ClientId);
            request.AddHeader("client_secret", currentApiToken.ClientSecret);
            request.AddHeader("refresh_token", currentApiToken.RefreshToken);
            
            // Execute the Request
            IRestResponse response = client.Execute<ApiToken>(request);

            // Treat the Response
            if(response.StatusCode == HttpStatusCode.OK)
            {
                // Deserialize the response to an ApiToken object
                ApiToken newApiToken = JsonConvert.DeserializeObject<ApiToken>(response.Content);

                // Update the attributes that changed upon the new access token generated
                currentApiToken.AccessToken = newApiToken.AccessToken;
                currentApiToken.ExpiresAt = newApiToken.ExpiresAt;
                currentApiToken.ExpiresIn = newApiToken.ExpiresIn;

                // Update the database registry
                _apiTokenService.Update(currentApiToken);
            }
            else
            {
                throw new AccessTokenNotRefreshed("Could not refresh the access token.");
            }
        }
    }
}
