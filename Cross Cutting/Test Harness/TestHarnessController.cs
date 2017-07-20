using Microsoft.AspNetCore.Mvc;
using Warehouse.API.Cross_Cutting.Signatures;
using Warehouse.API.Models;

namespace Warehouse.API.Cross_Cutting.Test_Harness
{
    [Route("api/[controller]")]
    public class TestHarnessController : Controller
    {
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
    }
}
