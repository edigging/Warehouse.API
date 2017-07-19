using System.ComponentModel.DataAnnotations;

namespace Warehouse.API.Models
{
    public class ReceiverDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string HouseNumber { get; set; }

        [Required]
        public string AddressText { get; set; }

        public string AddressAdditionalInfo { get; set; } // e.g. apt. number

        [Required]
        public string Country { get; set; }

        [Required]
        public string ZipCode { get; set; }
    }
}
