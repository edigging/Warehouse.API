using System;

namespace Warehouse.API.Tenants
{
    public class Tenant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsAuthorized => !String.IsNullOrWhiteSpace(Name);
        public string HMACKey { get; set; }       
        public static Tenant Empty => new Tenant();
    }
}
