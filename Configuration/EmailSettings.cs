namespace Warehouse.API.Configuration
{
    public class EmailSettings
    {
        public string SendGridApiKey { get; set; }
        public string FromEmail { get; set; }
        public string WarehouseNotificationEmail { get; set; }
        public string WarehouseNotificationEmailCC { get; set; }
    }
}
