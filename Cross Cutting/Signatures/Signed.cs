using Newtonsoft.Json;
using System;

namespace Warehouse.API.Cross_Cutting.Signatures
{
    public class Signed<T>
    {
        public T Payload { get; set; }
        public String Signature { get; set; }
        public bool IsValid(string key)
        {
            var hmac = new HMACSHA1Helper();
            var computedSignature = hmac.ComputeHash(key, JsonConvert.SerializeObject(Payload));

            return computedSignature == Signature;           
        }


        public static Signed<T> Build(T payload, string key)
        {
            var hmac = new HMACSHA1Helper();
            var computedSignature = hmac.ComputeHash(key, JsonConvert.SerializeObject(payload));

            return new Signed<T>
            {
                Payload = payload,
                Signature = computedSignature
            };
        }
    }
}
