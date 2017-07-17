namespace Warehouse.API.Models
{
    public class SaveShipmentResponse
    {
        public string TrackingNumber { get; set; }
        public string LabelPdfBinaryDataBase64Encoded { get; set; }
}
}
