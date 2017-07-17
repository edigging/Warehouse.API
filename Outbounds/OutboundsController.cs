using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Warehouse.API.Services;
using Warehouse.API.Models;

namespace Warehouse.API.Outbounds
{
    [Route("api/[controller]")]
    public class OutboundsController : Controller
    {
        IGeoshipClient _geoshipClient;
        IEmailNotificationService _emailNotificationService;

        public OutboundsController(IGeoshipClient geoshipClient, IEmailNotificationService emailNotificationService)
        {
            _geoshipClient = geoshipClient;
            _emailNotificationService = emailNotificationService;
        }

        // POST api/outbounds
        [HttpPost]
        public async Task<OutboundResponse> Post([FromBody]OutboundRequest request)
        {
            var response = await _geoshipClient.SaveShipmentAndCreateLabel(new SaveShipmentRequest {
                ProductPrice = request.ProductPrice,
                ReceiverFirstName = request.ReceiverFirstName,
                ReceiverLastName = request.ReceiverLastName,
                ReceiverPhoneNumber = request.ReceiverPhoneNumber,
                ReceiverHouseNumber = request.ReceiverHouseNumber,
                ReceiverAddressText = request.ReceiverAddressText,
                ReceiverAddressAdditionalInfo = request.ReceiverAddressAdditionalInfo,
                ReceiverCountry = request.ReceiverCountry,
                ReceiverZipCode = request.ReceiverZipCode
            });

            await _emailNotificationService.SendNotificationToWarehouse(new SendNotificationRequest {
                OrderNumber = request.OrderNumber,
                ProductName = request.ProductName,
                ProductQuantity = request.ProductQuantity,
                LabelPdfBinaryDataBase64Encoded = response.LabelPdfBinaryDataBase64Encoded
            });

            return new OutboundResponse
            {
                TrackingNumber = response.TrackingNumber
            };
        }
    }
}
