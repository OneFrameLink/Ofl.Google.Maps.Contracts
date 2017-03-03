using System;
using Newtonsoft.Json;
using Ofl.Google.Maps.Serialization.Newtonsoft;

namespace Ofl.Google.Maps
{
    public class TimeZoneResponse
    {
        [JsonProperty("dstOffset")]
        [JsonConverter(typeof(SecondsToTimeSpanJsonConverter))]
        public TimeSpan DaylightSavingsTimeOffset { get; set; }

        [JsonConverter(typeof(SecondsToTimeSpanJsonConverter))]
        public TimeSpan RawOffset { get; set; }

        public string TimeZoneId { get; set; }

        public string TimeZoneName { get; set; }

        public Status Status { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }
}
