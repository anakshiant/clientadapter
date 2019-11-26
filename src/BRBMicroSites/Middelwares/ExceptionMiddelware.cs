using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Middelwares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExceptionMiddelware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddelware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            try
            {
                await _next(httpContext);
            }
            catch (Exception exception)
            {
                if (!httpContext.Response.HasStarted)
                {
                    httpContext.Response.Clear();
                    httpContext.Response.Headers.Add("content-type", "application/json");
                    await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(new ApiResponse<ErrorResponse> { Data = new ErrorResponse(exception.Message) }));
                }
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExceptionMiddelwareExtensions
    {
        public static IApplicationBuilder UseExceptionMiddelware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddelware>();
        }
    }

    public class ErrorResponse
    {
        public string Message { get; set; }
        public ErrorResponse(string message)
        {
            Message = message;
        }
    }
}
