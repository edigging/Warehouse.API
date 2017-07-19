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

        // POST api/outbounds
        [HttpPost]
        [TenantAuthorized]
        // don't forget to put x-client-id header with value fac2add8-406c-4aa6-a03b-0333123c9dfc
        public IActionResult Post([FromBody]OutboundRequest request)
        {
            if (ModelState.IsValid)
            {
                var signed = Signed<OutboundRequest>.Build(request, _tenant.HMACKey);

                //{ "OrderNumber":"5","Product":{ "Name":"Elier","Quantity":2,"Price":41.50},"Receiver":{ "FirstName":"Test","LastName":"Receiver","PhoneNumber":"23456789","HouseNumber":"122","AddressText":"somewhere in Riga","AddressAdditionalInfo":"apt. 35","Country":"LATVIA","ZipCode":"1058"} }
                //61156e9c9b30ae5765e646ea7a5781bc5af0944d

                return new JsonResult(new { signature = signed.Signature });
            }
            else
            {
                return BadRequest(ModelState);
            }
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
