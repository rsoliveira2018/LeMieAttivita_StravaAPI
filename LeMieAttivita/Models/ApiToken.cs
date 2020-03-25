using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMieAttivita.Models
{
    public class ApiToken
    {
        public int Id { get; set; }
        [JsonProperty(PropertyName = "token_type")] public string TokenType { get; set; }
        [JsonProperty(PropertyName = "access_token")] public string AccessToken { get; set; }
        [JsonProperty(PropertyName = "expires_at")] public DateTime ExpiresAt { get; set; }
        [JsonProperty(PropertyName = "expires_in")] public int ExpiresIn { get; set; }
        [JsonProperty(PropertyName = "refresh_token")] public string RefreshToken { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public DateTime RetrievalDate { get; set; } = DateTime.Now;
    }
}
