using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Google.Maps
{
    public interface IMapsClient
    {
        Task<TimeZoneResponse> GetTimeZoneAsync(TimeZoneRequest request, CancellationToken cancellationToken);
    }
}
