using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using Warehouse.API.Configuration;
using Warehouse.API.Models;

namespace Warehouse.API.Services
{
    public class EmailNotificationService : IEmailNotificationService
    {
        private readonly EmailSettings _emailSettings;

        public EmailNotificationService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task SendNotificationToWarehouse(SendNotificationRequest sendNotificationRequest)
        {
            var mailBody = new StringBuilder();
            mailBody.AppendFormat("<strong>Client:</strong> {0}<br/>", sendNotificationRequest.ClientName);
            mailBody.AppendFormat("<strong>Order #:</strong> {0}<br/>", sendNotificationRequest.OrderNumber);
            mailBody.AppendFormat("<strong>Name of product:</strong> {0}<br/>", sendNotificationRequest.ProductName);
            mailBody.AppendFormat("<strong>Quantity:</strong> {0} pc<br/>", sendNotificationRequest.ProductQuantity);

            var labelPdfAttachment = new Attachment() {
                Content = sendNotificationRequest.LabelPdfBinaryDataBase64Encoded,
                Filename = "DPD_label.pdf",
                Type = "application/pdf"
            };

            var msg = MailHelper.CreateSingleEmail(
                from: new EmailAddress(_emailSettings.FromEmail),
                to: new EmailAddress(_emailSettings.WarehouseNotificationEmail),
                subject: $"Order #{sendNotificationRequest.OrderNumber}",
                plainTextContent: null,
                htmlContent: mailBody.ToString()
            );

            msg.Attachments = new List<Attachment>() { labelPdfAttachment };

            foreach (var ccEmail in _emailSettings.WarehouseNotificationEmailCC.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                msg.AddCc(ccEmail.Trim());
            }

            foreach (var bccEmail in _emailSettings.WarehouseNotificationEmailBCC.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                msg.AddBcc(bccEmail.Trim());
            }

            var client = new SendGridClient(_emailSettings.SendGridApiKey);

            await client.SendEmailAsync(msg);
        }


    }
}
