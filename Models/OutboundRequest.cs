namespace Warehouse.API.Models
{
    public class OutboundRequest
    {
        public string OrderNumber { get; set; }

        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
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
