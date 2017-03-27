using System.Threading;
using System.Threading.Tasks;
using Ofl.Google.Maps.Geocode;
using Ofl.Google.Maps.TimeZone;

namespace Ofl.Google.Maps
{
    public interface IMapsClient
    {
        Task<TimeZoneResponse> GetTimeZoneAsync(TimeZoneRequest request, CancellationToken cancellationToken);

        Task<GeocodeResponse> GeocodeAsync(GeocodeRequest request, CancellationToken cancellationToken);
    }
}
