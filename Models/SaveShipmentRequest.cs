namespace Warehouse.API.Models
{
    public class SaveShipmentRequest
    {
        public decimal ProductPrice { get; set; }

        public string ReceiverFirstName { get; set; }
        public string ReceiverLastName { get; set; }
        public string ReceiverPhoneNumber { get; set; }
        public string ReceiverHouseNumber { get; set; }
        public string ReceiverAddressText { get; set; }
        public string ReceiverAddressAdditionalInfo { get; set; }
        public string ReceiverCountry { get; set; }
        public string ReceiverZipCode { get; set; }
    }
}
