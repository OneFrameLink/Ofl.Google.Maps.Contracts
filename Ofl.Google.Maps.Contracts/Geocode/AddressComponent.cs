using System.Collections.Generic;
using Newtonsoft.Json;

namespace Ofl.Google.Maps.Geocode
{
    public class AddressComponent
    {
        [JsonProperty("long_name")]
        public string LongName { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        public IReadOnlyCollection<string> Types { get; set; }
    }
}
