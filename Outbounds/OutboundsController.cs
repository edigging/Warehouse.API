using Microsoft.AspNetCore.Mvc;
using Warehouse.API.Cross_Cutting.Signatures;
using Warehouse.API.Tenants;

namespace Warehouse.API.Outbounds
{
    [Route("api/[controller]")]
    public class OutboundsController : Controller
    {
        #region Dependencies

        public OutboundsController(Tenant tenant)
        {
            Tenant = tenant;
        }

        public Tenant Tenant { get; set; }

        #endregion      

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
                //do some stuff
            }


            return new OutboundResponse();
        }
    }

    #region Messages

    public class OutboundRequest
    {
        public string Code { get; set; }
    }

    public class OutboundResponse
    {

    }

    #endregion
}
