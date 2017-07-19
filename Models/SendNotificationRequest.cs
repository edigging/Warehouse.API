namespace Warehouse.API.Models
{
    public class SendNotificationRequest
    {
        public string ClientName { get; set; }
        public string OrderNumber { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public string LabelPdfBinaryDataBase64Encoded { get; set; }
    }
}
