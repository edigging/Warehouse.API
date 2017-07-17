using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Warehouse.API.Tenants
{
    public class TenantAuthorizedAttribute : AuthorizeAttribute
    {
        public const string PolicyName = "TenantAuthorizedPolicy";
        public TenantAuthorizedAttribute()
        {
            Policy = PolicyName;
        }
    }

    public class TenantAuthorizedRequirement : IAuthorizationRequirement
    {

    }


    public class TenantAuthorizationHandler : AuthorizationHandler<TenantAuthorizedRequirement>
    {
        public Tenant Tenant { get; }
        public TenantAuthorizationHandler(Tenant tenant)
        {
            Tenant = tenant;
        }


        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, TenantAuthorizedRequirement requirement)
        {
            if (Tenant.IsAuthorized)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }

    public static class ConfigurationExtensions
    {
        public static void RegisterTenantAuthorization(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy(TenantAuthorizedAttribute.PolicyName, policy => policy.Requirements.Add(new TenantAuthorizedRequirement()));
            });

            services.AddTransient<IAuthorizationHandler, TenantAuthorizationHandler>();
        }
    }
}
