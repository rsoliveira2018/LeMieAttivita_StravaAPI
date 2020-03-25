using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMieAttivita.Models
{
    public class Athlete
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "username")] public string Username { get; set; }
        [JsonProperty(PropertyName = "resource_state")] public int ResourceState { get; set; }
        [JsonProperty(PropertyName = "firstname")] public string FirstName { get; set; }
        [JsonProperty(PropertyName = "lastname")] public string LastName { get; set; }
        [JsonProperty(PropertyName = "city")] public string City { get; set; }
        [JsonProperty(PropertyName = "state")] public string State { get; set; }
        [JsonProperty(PropertyName = "country")] public string Country { get; set; }
        [JsonProperty(PropertyName = "sex")] public string Sex { get; set; }
        [JsonProperty(PropertyName = "premium")] public string Premium { get; set; }
        [JsonProperty(PropertyName = "summit")] public string Summit { get; set; }
        [JsonProperty(PropertyName = "created_at")] public DateTime CreatedAt { get; set; }
        [JsonProperty(PropertyName = "updated_at")] public DateTime UpdatedAt { get; set; }
        [JsonProperty(PropertyName = "badge_type_id")] public int BadgeTypeId { get; set; }
        [JsonProperty(PropertyName = "profile_medium")] public string ProfilePicMedium { get; set; }
        [JsonProperty(PropertyName = "profile")] public string ProfilePicLarge { get; set; }
        [JsonProperty(PropertyName = "friend")] public string Friend { get; set; }
        [JsonProperty(PropertyName = "follower")] public string Follower { get; set; }
        [JsonProperty(PropertyName = "follower_count")] public int FollowerCount { get; set; }
        [JsonProperty(PropertyName = "friend_count")] public int FriendCount { get; set; }
        [JsonProperty(PropertyName = "mutual_friend_count")] public int MutualFriendCount { get; set; }
        [JsonProperty(PropertyName = "athlete_type")] public int AthleteType { get; set; }
        [JsonProperty(PropertyName = "date_preference")] public string DatePreference { get; set; }
        [JsonProperty(PropertyName = "measurement_preference")] public string MeasurementPreference { get; set; }
        // [JsonProperty(PropertyName = "clubs")] -- series of clubs, maybe it could be rendered into a list of clubs (class to be created)
        [JsonProperty(PropertyName = "ftp")] public string FTP { get; set; }
        [JsonProperty(PropertyName = "weight")] public double Weight { get; set; }
        public ApiToken ApiToken { get; set; }
        public int ApiTokenId { get; set; }
        // [JsonProperty(PropertyName = "bikes")] -- series of bikes, maybe it could be rendered into a list of bikes (class to be created)
        // [JsonProperty(PropertyName = "shoes")] -- series of shoes, maybe it could be rendered into a list of shoes (class to be created)
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("\tId: " + Id);
            stringBuilder.AppendLine("\tUsername: " + Username);
            stringBuilder.AppendLine("\tResource State: " + ResourceState);
            stringBuilder.AppendLine("\tFirst Name: " + FirstName);
            stringBuilder.AppendLine("\tLast Name: " + LastName);
            stringBuilder.AppendLine("\tCity: " + City);
            stringBuilder.AppendLine("\tState: " + State);
            stringBuilder.AppendLine("\tCountry: " + Country);
            stringBuilder.AppendLine("\tSex: " + Sex);
            stringBuilder.AppendLine("\tPremium: " + Premium);
            stringBuilder.AppendLine("\tSummit: " + Summit);
            stringBuilder.AppendLine("\tCreated At: " + CreatedAt);
            stringBuilder.AppendLine("\tUpdated At: " + UpdatedAt);
            stringBuilder.AppendLine("\tBadge Type Id: " + BadgeTypeId);
            stringBuilder.AppendLine("\tProfile Picture Medium Size: " + ProfilePicMedium);
            stringBuilder.AppendLine("\tProfile Picture Large Size: " + ProfilePicLarge + "\n");
            stringBuilder.AppendLine("\tFriend: " + Friend);
            stringBuilder.AppendLine("\tFollower: " + Follower);
            stringBuilder.AppendLine("\tFollower Count: " + FollowerCount);
            stringBuilder.AppendLine("\tFriend Count: " + FriendCount);
            stringBuilder.AppendLine("\tMutual Friend Count: " + MutualFriendCount);
            stringBuilder.AppendLine("\tAthlete Type: " + AthleteType);
            stringBuilder.AppendLine("\tDate Preference: " + DatePreference);
            stringBuilder.AppendLine("\tMeasurement Preference: " + MeasurementPreference);
            stringBuilder.AppendLine("\tFTP: " + FTP);
            stringBuilder.AppendLine("\tWeight: " + Weight);

            return stringBuilder.ToString();
        }
    }
}
