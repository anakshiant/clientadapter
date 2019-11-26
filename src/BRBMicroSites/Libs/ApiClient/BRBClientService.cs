using System;
using System.Net.Http.Headers;
using BRBMicroSites.Libs.ApiClient;
using BRBMicroSites.Services.HostTokenMapService;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Polly;

namespace BRBMicroSites.Libs.ApiClient
{
    public static class BRBClientService
    {
        public static void AddBRBClient(this IServiceCollection services, string baseUrl)
        {
            services.AddHttpClient<IBRBClient, BRBClient>((ServiceProvider, httpClient) =>
            {
                var httpContextAccessor = ServiceProvider.GetService<IHttpContextAccessor>();

                HttpContext httpContext = httpContextAccessor.HttpContext;


                string token = httpContext.User.Identity.IsAuthenticated
                ? httpContext.User.Identity.Name
                : string.Empty;

                httpClient.BaseAddress = new Uri(baseUrl);
                httpClient.Timeout = TimeSpan.FromSeconds(20);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {token}");
            }).AddTransientHttpErrorPolicy(policy =>
            {
                return policy
                .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound || msg.StatusCode == System.Net.HttpStatusCode.BadRequest)
                .WaitAndRetryAsync(6, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
            });
        }
    }
}