using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;
using Warehouse.API.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Globalization;

namespace Warehouse.API.Services
{
    public class DPDPublicApiClient : IDPDPublicApiClient
    {
        public async Task<TrackingStatusResponse> GetTrackingStatus(TrackingStatusRequest request)
        {
            var client = new RestClient("https://tracking.dpd.de/cgi-bin/simpleTracking.cgi");
            var restRrequest = new RestRequest("", Method.GET);
            restRrequest.AddParameter("parcelNr", request.TrackingNumber);
            restRrequest.AddParameter("locale", "en_D2");
            restRrequest.AddParameter("type", "1");

            var tcs = new TaskCompletionSource<TrackingStatusResponse>();

            client.ExecuteAsync(restRrequest, restResponse => {

                

                var statusJSson = JsonConvert.DeserializeObject<JObject>(restResponse.Content.Trim('(', ')'));

                var response = new TrackingStatusResponse();
                response.TrackingNumber = statusJSson.SelectToken("TrackingStatusJSON.shipmentInfo.parcelNumber").Value<string>();

                if (restResponse.Content.IndexOf("TrackingStatusJSON") > -1)
                {
                    response.DeliveryStatus = statusJSson.SelectToken("TrackingStatusJSON.shipmentInfo.deliveryStatusMessage").Value<string>();
                    response.TrackingInfo = new List<TrackingStatus>();

                    foreach (JObject statusInfo in statusJSson.SelectToken("TrackingStatusJSON.statusInfos").Value<JArray>())
                    {
                        if (statusInfo.Value<string>("detailLevel") != "0") continue;

                        response.TrackingInfo.Add(new TrackingStatus
                        {
                            DateAndTime = DateTime.ParseExact($"{statusInfo["date"]} {statusInfo["time"]}".Trim(), "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None),
                            Place = statusInfo.Value<string>("city"),
                            Status = statusInfo.Value<JArray>("contents")[0].Value<string>("label")
                        });
                    }
                }
                else
                {
                    response.DeliveryStatus = "Status in not available. Possible reasons: invalid tracking number or status was not registered yet by DPD";
                }

                tcs.SetResult(response);
            });

            return await tcs.Task;
        }
    }
}
