using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ofl.Google.Maps.Geocode
{
    public class Result
    {
        [JsonProperty("address_components")]
        public IReadOnlyCollection<AddressComponent> AddressComponents { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        public Geometry Geomoetry { get; set; }
        
        [JsonProperty("place_id")]
        public string PlaceId { get; set; }
        
        public IReadOnlyCollection<string> Types { get; set; }
    }
}
