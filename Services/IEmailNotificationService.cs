using System.Threading.Tasks;
using Warehouse.API.Models;

namespace Warehouse.API.Services
{
    public interface IEmailNotificationService
    {
        Task SendNotificationToWarehouse(SendNotificationRequest sendNotificationRequest);
    }
}
