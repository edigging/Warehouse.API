namespace Warehouse.API.Configuration
{
    public class EmailSettings
    {
        public string SendGridApiKey { get; set; }
        public string FromEmail { get; set; }
        public string WarehouseNotificationEmail { get; set; }
        public string WarehouseNotificationEmailCC { get; set; }
        public string WarehouseNotificationEmailBCC { get; set; } // in case someone doesn't want hes email to appear in CC
    }
}
