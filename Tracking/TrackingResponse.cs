using System.Collections.Generic;

namespace Warehouse.API.Models
{
    public class TrackingResponse
    {
        public IList<TrackingStatusResponse> Statuses { get; set; }
    }
}
