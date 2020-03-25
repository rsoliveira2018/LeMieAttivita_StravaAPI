using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LeMieAttivita.Models
{
    public class Activity
    {
        [JsonProperty(PropertyName = "id")] public double Id { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonProperty(PropertyName = "distance")] public double Distance { get; set; }
        [JsonProperty(PropertyName = "moving_time")] public string MovingTime { get; set; }
        [JsonProperty(PropertyName = "elapsed_time")] public string ElapsedTime { get; set; }
        [JsonProperty(PropertyName = "total_elevation_gain")] public double TotalElevationGain { get; set; }
        [DisplayName("Type")] [JsonProperty(PropertyName = "type")] public string Ride { get; set; }
        [JsonProperty(PropertyName = "workout_type")] public int WorkoutType { get; set; }
        // [JsonProperty(PropertyName = "external_id")] public int ExternalId { get; set; }
        // [JsonProperty(PropertyName = "upload_id")] public int UploadId { get; set; }
        [JsonProperty(PropertyName = "start_date")] public DateTime StartDate { get; set; }
        [JsonProperty(PropertyName = "start_date_local")] public DateTime StartDateLocal { get; set; }
        [JsonProperty(PropertyName = "timezone")] public string Timezone { get; set; }
        [JsonProperty(PropertyName = "utc_offset")] public double UtcOffset { get; set; }
        // [NotMapped] [JsonProperty(PropertyName = "start_latlng")] public (double, double) StartLatLng { get; set; }
        // [NotMapped] [JsonProperty(PropertyName = "end_latlng")] public (double, double) EndLatLng { get; set; }
        [JsonProperty(PropertyName = "location_city")] public string LocationCity { get; set; }
        [JsonProperty(PropertyName = "location_state")] public string LocationState { get; set; }
        [JsonProperty(PropertyName = "location_country")] public string LocationCountry { get; set; }
        [JsonProperty(PropertyName = "start_latitude")] public string StartLatitude { get; set; }
        [JsonProperty(PropertyName = "start_longitude")] public string StartLongitude { get; set; }
        [JsonProperty(PropertyName = "achievement_count")] public int AchievementCount { get; set; }
        [JsonProperty(PropertyName = "kudos_count")] public int KudosCount { get; set; }
        [JsonProperty(PropertyName = "comment_count")] public int CommentCount { get; set; }
        [JsonProperty(PropertyName = "athlete_count")] public int AthleteCount { get; set; }
        [JsonProperty(PropertyName = "photo_count")] public int PhotoCount { get; set; }
        // [JsonProperty(PropertyName = "map")] -- will not be implemented (at first, at least)
        [JsonProperty(PropertyName = "trainer")] public bool Trainer { get; set; }
        [JsonProperty(PropertyName = "commute")] public bool Commute { get; set; }
        [JsonProperty(PropertyName = "manual")] public bool Manual { get; set; }
        [JsonProperty(PropertyName = "private")] public bool Private { get; set; }
        [JsonProperty(PropertyName = "visibility")] public string Visibility { get; set; }
        [JsonProperty(PropertyName = "flagged")] public bool Flagged { get; set; }
        [JsonProperty(PropertyName = "gear_id")] public string GearId { get; set; }
        //[JsonProperty(PropertyName = "from_accepted_tag")] public bool FromAcceptedTag { get; set; }
        //[JsonProperty(PropertyName = "upload_id_str")] public int UploadIdStr { get; set; }
        [JsonProperty(PropertyName = "average_speed")] public double AverageSpeed { get; set; }
        [JsonProperty(PropertyName = "max_speed")] public double MaxSpeed { get; set; }
        [JsonProperty(PropertyName = "average_watts")] public double AverageWatts { get; set; }
        [JsonProperty(PropertyName = "kilojoules")] public double KiloJoules { get; set; }
        [JsonProperty(PropertyName = "device_watts")] public bool DeviceWatts { get; set; }
        [JsonProperty(PropertyName = "has_heartrate")] public bool HasHeartrate { get; set; }
        [JsonProperty(PropertyName = "heartrate_opt_out")] public bool HeartrateOptOut { get; set; }
        [JsonProperty(PropertyName = "display_hide_heartrate_option")] public bool DisplayHideHeartrateOption { get; set; }
        [JsonProperty(PropertyName = "elev_high")] public double ElevHigh { get; set; }
        [JsonProperty(PropertyName = "elev_low")] public double ElevLow { get; set; }
        [JsonProperty(PropertyName = "pr_count")] public int PRCount { get; set; }
        [JsonProperty(PropertyName = "total_photo_count")] public int TotalPhotoCount { get; set; }
        [JsonProperty(PropertyName = "has_kudoed")] public bool HasKudoed { get; set; }
        [JsonProperty(PropertyName = "description")] public string Description { get; set; }
        [JsonProperty(PropertyName = "calories")] public double Calories { get; set; }
        [JsonProperty(PropertyName = "perceived_exertion")] public bool False { get; set; }
        [JsonProperty(PropertyName = "prefer_perceived_exercion")] public bool PreferPerceivedExertion { get; set; }
        // [JsonProperty(PropertyName = "gear")] -- object representing the bike/shoes used in the activity
        // [JsonProperty(PropertyName = "photos")] -- list of photos upload to the activity
        [JsonProperty(PropertyName = "device_name")] public string DeviceName { get; set; }
        // [JsonProperty(PropertyName = "segment_efforts")] -- array with all the segments in the activity + the effort of the athlete on them during the current activity
        // [JsonProperty(PropertyName = "splits_metric")] -- not sure what this is.. will stay disabled for now
        // [JsonProperty(PropertyName = "splits_standard")] -- not sure what this is.. will stay disabled for now
        // [JsonProperty(PropertyName = "laps")] -- array of laps
        // [JsonProperty(PropertyName = "embed_token")] public string EmbedToken { get; set; }
        // [JsonProperty(PropertyName = "available_zones")] -- not sure what this is.. will stay disabled for now
        public Athlete Athlete { get; set; }
        public int AthleteId { get; set; }
    }
}
