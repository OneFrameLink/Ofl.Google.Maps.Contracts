﻿using System.Collections.Generic;

namespace Ofl.Google.Maps.Geocode
{
    public class GeocodeResponse
    {
        public GeocodeRequest Request { get; set; }

        public IReadOnlyCollection<Result> Results { get; set; }

        public string Status { get; set; }
    }
}
