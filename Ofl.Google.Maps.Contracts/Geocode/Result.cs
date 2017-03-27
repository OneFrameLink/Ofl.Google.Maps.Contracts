using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ofl.Google.Maps.Geocode
{
    public class Result
    {
        public IReadOnlyCollection<AddressComponent> AddressComponents { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        public Geometry Geomoetry { get; set; }
    }
}
