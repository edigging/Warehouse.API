using Microsoft.AspNetCore.Mvc;
using Warehouse.API.Tenants;

namespace Warehouse.API.Outbounds
{

    [Route("api/[controller]")]
    public class OutboundsController : Controller
    {
        // POST api/outbounds
        [HttpPost]
        [TenantAuthorized]
        // don't forget to put x-client-id header with value fac2add8-406c-4aa6-a03b-0333123c9dfc
        public OutboundResponse Post([FromBody]OutboundRequest request)
        {
            //todo: figure out what to send to DPD

            //todo: figure out what to return back

            return new OutboundResponse();
        }
    }

    #region Messages

    public class OutboundRequest
    {

    }

    public class OutboundResponse
    {

    }

    #endregion
}
