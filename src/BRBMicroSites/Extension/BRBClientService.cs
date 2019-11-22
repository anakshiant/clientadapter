using System;
using System.Net.Http.Headers;
using BRBMicroSites.Libs.ApiClient;
using BRBMicroSites.Services.HostTokenMapService;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Polly;

namespace BRBMicroSites.Extension
{
    public static class BRBClientService
    {
        public static void AddBRBClient(this IServiceCollection services, string baseUrl)
        {
            services.AddHttpClient<IBRBClient, BRBClient>((ServiceProvider, httpClient) =>
            {
                var httpContextAccessor = ServiceProvider.GetService<IHttpContextAccessor>();
                var hostTokenMapService = ServiceProvider.GetService<IHostTokenMapService>();

                HttpContext httpContext = httpContextAccessor.HttpContext;

                httpClient.BaseAddress = new Uri(baseUrl);
                httpClient.Timeout = TimeSpan.FromSeconds(20);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                if (httpContext.Request.Host.Host == "localhost")
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {hostTokenMapService.GetToken("www.smilebox.com")}");
                }
            }).AddTransientHttpErrorPolicy(policy =>
            {
                return policy
                .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
                .WaitAndRetryAsync(6, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
            });
        }
    }
}