using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ofl.Google.Maps.Geocode
{
    public class Geometry
    {
        public Coordinates Location { get; set; }

        [JsonProperty("location_type")]
        public string LocationType { get; set; }

        public Viewport Viewport { get; set; }

        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        public IReadOnlyCollection<string> Types { get; set; }
    }
}
