using Microsoft.AspNetCore.Mvc;

namespace Warehouse.API.Outbounds
{

    [Route("api/[controller]")]
    public class OutboundsController : Controller
    {
        // POST api/outbounds
        [HttpPost]
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
