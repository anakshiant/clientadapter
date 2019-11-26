using Microsoft.Extensions.DependencyInjection;

namespace BRBMicroSites.Auth
{
    public static class AuthExtension
    {
        /// <summary>
        /// Autorization extension for service collection
        /// </summary>
        /// <param name="services"></param>
        public static void AddBRBAuthorization(this IServiceCollection services)
        {
            services.AddAuthorization(option =>
            {
                option.AddPolicy("BRB", policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        if (context.User != null &&
                        context.User.Identity != null &&
                        context.User.Identity.IsAuthenticated)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    });
                });
            });
        }

        /// <summary>
        /// Authentication extension for service collection
        /// </summary>
        /// <param name="services"></param>
        public static void AddBRBAuthentication(this IServiceCollection services)
        {
            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = "BRB";
                option.AddScheme<AuthenticationHandler>("BRB", "BRB");
            });
        }
    }
}
