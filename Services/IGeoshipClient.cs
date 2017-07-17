using System.Threading.Tasks;
using Warehouse.API.Models;

namespace Warehouse.API.Services
{
    public interface IGeoshipClient
    {
        Task<SaveShipmentResponse> SaveShipmentAndCreateLabel(SaveShipmentRequest saveShipmentRequest);
    }
}
