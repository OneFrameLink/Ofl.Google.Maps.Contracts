using Newtonsoft.Json;

namespace Ofl.Google.Maps.Geocode
{
    public class Coordinates
    {
        [JsonProperty("lat")]
        public decimal Latitude { get; set; }

        [JsonProperty("lng")]
        public decimal Longitude { get; set; }
    }
}
