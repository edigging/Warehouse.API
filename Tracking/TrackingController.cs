using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.API.Cross_Cutting.Signatures;
using Warehouse.API.Exceptions;
using Warehouse.API.Models;
using Warehouse.API.Services;
using Warehouse.API.Tenants;

namespace Warehouse.API.Tracking
{

    [Route("api/[controller]")]
    public class TrackingController : Controller
    {
        IDPDPublicApiClient _dpdPublicApiClient;
        public Tenant _tenant { get; set; }

        public TrackingController(Tenant tenant, IDPDPublicApiClient dpdPublicApiClient)
        {
            _tenant = tenant;
            _dpdPublicApiClient = dpdPublicApiClient;
        }

        [TenantAuthorized]
        [HttpPost("[action]")]
        public async Task<TrackingResponse> GetStatusByTrackingNumber([FromBody]Signed<TrackingRequest> request)
        {
            if (request.IsValid(_tenant.HMACKey))
            {
                var response = new TrackingResponse() {
                    Statuses = new List<TrackingStatusResponse>()
                };

                foreach (var trackingNumber in request.Payload.TrackingNumbers)
                {
                    var statusInfo = await _dpdPublicApiClient.GetTrackingStatus(new TrackingStatusRequest { TrackingNumber = trackingNumber });
                    response.Statuses.Add(statusInfo);
                }

                return response;
            }

            throw new BadRequestException();
        }
    }
}
