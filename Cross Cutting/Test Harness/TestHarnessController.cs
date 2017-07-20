using Microsoft.AspNetCore.Mvc;
using Warehouse.API.Cross_Cutting.Signatures;
using Warehouse.API.Models;
using Warehouse.API.Tenants;

namespace Warehouse.API.Cross_Cutting.Test_Harness
{
    [Route("api/[controller]")]
    public class TestHarnessController : Controller
    {
        #region Dependencies

        readonly Tenant _tenant;
        public TestHarnessController(Tenant tenant)
        {
            _tenant = tenant;
        }

        #endregion

        // POST api/outbounds
        [HttpGet("outbound")]
        public IActionResult Outbound()
        {
            var request = new OutboundRequest()
            {
                OrderNumber = "123_test",
                Product = new ProductDto()
                {
                    Name = "Elier test",
                    Price = 49,
                    Quantity = 1
                },
                Receiver = new ReceiverDto
                {
                    Country = "Germany",
                    FirstName = "Ron",
                    LastName = "Piercy",
                    PhoneNumber = "123456789",
                    AddressText = "Some street",
                    HouseNumber = "10 abc",
                    AddressAdditionalInfo = "additional address info",
                    ZipCode = "1234"
                }
            };

            var signed = Signed<OutboundRequest>.Build(request, "9779e484-139a-4b40-9361-628742811e53");
            return new JsonResult(signed);
        }

        [HttpGet("tracking")]
        public IActionResult Tracking()
        {
            var request = new TrackingRequest()
            {
                TrackingNumbers = new string[] { "tr1", "tr2" }
            };

            var signed = Signed<TrackingRequest>.Build(request, "9779e484-139a-4b40-9361-628742811e53");
            return new JsonResult(signed);
        }

        // POST api/outbounds
        [HttpPost("outbound")]
        [TenantAuthorized]       
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

        // POST api/outbounds
        [HttpPost("tracking")]
        [TenantAuthorized]
        public IActionResult Post([FromBody]TrackingRequest request)
        {
            if (ModelState.IsValid)
            {
                var signed = Signed<TrackingRequest>.Build(request, _tenant.HMACKey);
                /*                 
                    {
                        "trackingNumbers": [
                        "tr1",
                        "tr2"
                        ]
                     }
                */

                return new JsonResult(new { signature = signed.Signature });
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
