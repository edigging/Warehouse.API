using System.Threading.Tasks;
using Warehouse.API.Models;

namespace Warehouse.API.Services
{
    public interface IDPDPublicApiClient
    {
        Task<TrackingStatusResponse> GetTrackingStatus(TrackingStatusRequest request);
    }
}
