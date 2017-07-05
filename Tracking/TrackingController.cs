using Microsoft.AspNetCore.Mvc;

namespace Warehouse.API.Tracking
{

    [Route("api/[controller]")]
    public class TrackingController : Controller
    {
        [HttpGet("{id}")]
        public TrackingResponse Get(int id)
        {
            //todo: figure out what to send to DPD

            //todo: figure out what to return back

            return new TrackingResponse();
        }
    }

    #region Messages

    public class TrackingRequest
    {

    }

    public class TrackingResponse
    {

    }

    #endregion
}
