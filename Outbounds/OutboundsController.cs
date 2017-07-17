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
        public Tenant Tenant { get; set; }

        public OutboundsController(Tenant tenant, IGeoshipClient geoshipClient, IEmailNotificationService emailNotificationService)
        {
            Tenant = tenant;
            _geoshipClient = geoshipClient;
            _emailNotificationService = emailNotificationService;
        }

        // POST api/outbounds
        [HttpPost]
        [TenantAuthorized]
        // don't forget to put x-client-id header with value fac2add8-406c-4aa6-a03b-0333123c9dfc
        public OutboundResponse Post([FromBody]OutboundRequest request)
        {
            //todo: figure out what to send to DPD

            //todo: figure out what to return back

            var signed = Signed<OutboundRequest>.Build(new OutboundRequest() { Code = "123" }, "9779e484-139a-4b40-9361-628742811e53");
            //d0d80751fef9786466b696e8560425660663a771

            return new OutboundResponse();
        }


        [TenantAuthorized]
        [HttpPost("[action]")]
        public OutboundResponse PostSigned([FromBody]Signed<OutboundRequest> request)
        {
            if (request.IsValid(Tenant.HMACKey))
            {
                var response = await _geoshipClient.SaveShipmentAndCreateLabel(new SaveShipmentRequest
                {
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

                await _emailNotificationService.SendNotificationToWarehouse(new SendNotificationRequest
                {
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
}
