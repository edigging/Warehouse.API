using Microsoft.AspNetCore.Http;
using SaasKit.Multitenancy;
using System.Threading.Tasks;

namespace Warehouse.API.Tenants
{
    public class TenantResolver : ITenantResolver<Tenant>
    {
        public async Task<TenantContext<Tenant>> ResolveAsync(HttpContext context)
        {
            return await Task.Run(() => BuildTenantContext(context));
        }

        private static TenantContext<Tenant> BuildTenantContext(HttpContext context)
        {
            if (context.Request.Headers["x-client-id"] == "fac2add8-406c-4aa6-a03b-0333123c9dfc")
            {
                var demoTenant = new Tenant
                {
                    Id = "fac2add8-406c-4aa6-a03b-0333123c9dfc",
                    Name = "Demo Tenant",
                    HMACKey = "9779e484-139a-4b40-9361-628742811e53"
                };
                return new TenantContext<Tenant>(demoTenant);
            }           
            else
            {
                return new TenantContext<Tenant>(Tenant.Empty);
            }
        }
    }
}
