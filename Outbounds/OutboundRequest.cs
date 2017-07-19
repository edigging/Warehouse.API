using System.ComponentModel.DataAnnotations;

namespace Warehouse.API.Models
{
    public class OutboundRequest
    {
        [Required]
        public string OrderNumber { get; set; }

        [Required]
        public ProductDto Product { get; set; }

        [Required]
        public ReceiverDto Receiver { get; set; }
    }
}
