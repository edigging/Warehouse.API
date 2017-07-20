using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Warehouse.API.Cross_Cutting.Signatures;
using Warehouse.API.Tenants;
using Warehouse.API.Services;
using Warehouse.API.Models;

namespace Warehouse.API.Outbounds
{
    [Route("api/[controller]")]
    public class OutboundsController : Controller
    {
        IGeoshipClient _geoshipClient;
        IEmailNotificationService _emailNotificationService;
        public Tenant _tenant;

        public OutboundsController(Tenant tenant, IGeoshipClient geoshipClient, IEmailNotificationService emailNotificationService)
        {
            _tenant = tenant;
            _geoshipClient = geoshipClient;
            _emailNotificationService = emailNotificationService;
        }    


        [TenantAuthorized]
        [HttpPost("[action]")]
        public async Task<IActionResult> PostSigned([FromBody]Signed<OutboundRequest> request)
        {
            if (request.IsValid(_tenant.HMACKey))
            {
                if (ModelState.IsValid)
                {
                    var response = await _geoshipClient.SaveShipmentAndCreateLabel(new SaveShipmentRequest
                    {
                        ProductPrice = request.Payload.Product.Price,
                        ReceiverFirstName = request.Payload.Receiver.FirstName,
                        ReceiverLastName = request.Payload.Receiver.LastName,
                        ReceiverPhoneNumber = request.Payload.Receiver.PhoneNumber,
                        ReceiverHouseNumber = request.Payload.Receiver.HouseNumber,
                        ReceiverAddressText = request.Payload.Receiver.AddressText,
                        ReceiverAddressAdditionalInfo = request.Payload.Receiver.AddressAdditionalInfo,
                        ReceiverCountry = request.Payload.Receiver.Country,
                        ReceiverZipCode = request.Payload.Receiver.ZipCode
                    });

                    await _emailNotificationService.SendNotificationToWarehouse(new SendNotificationRequest
                    {
                        ClientName = _tenant.Name,
                        OrderNumber = request.Payload.OrderNumber,
                        ProductName = request.Payload.Product.Name,
                        ProductQuantity = request.Payload.Product.Quantity,
                        LabelPdfBinaryDataBase64Encoded = response.LabelPdfBinaryDataBase64Encoded
                    });

                    return new JsonResult(new OutboundResponse
                    {
                        TrackingNumber = response.TrackingNumber
                    });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }

            return BadRequest();
        }
    }
}
