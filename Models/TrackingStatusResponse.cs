using System.Collections.Generic;

namespace Warehouse.API.Models
{
    public class TrackingStatusResponse
    {
        public string TrackingNumber { get; set; }
        public string DeliveryStatus { get; set; }
        public IList<TrackingStatusDto> TrackingInfo { get; set; }
    }
}
