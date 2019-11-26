using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;

using BRBMicroSites.Libs.ApiClient;
using BRBMicroSites.Services.HostTokenMapService;
using BRBMicroSites.Services.Auth;
using BRBMicroSites.Libs.Swagger;
using BRBMicroSites.Services.Translation;
using BRBMicroSites.Middelwares;

namespace BRBMicroSites
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(mvcOption =>
            {
                mvcOption.Filters.Add(new AuthorizeFilter("BRB"));
            });

            services.Configure<List<HostTokenMap>>(Configuration.GetSection("HostTokenMap"));

            services.AddSingleton<IHostTokenMapService, HostTokenMapService>();

            services.AddHttpContextAccessor();

            services.AddBRBClient(Configuration["BaseUrl"]);

            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "BRBMicrositeAdapter",
                    Description = "Api Adapter for microsites",
                    Version = "v1"
                });

                option.OperationFilter<AuthorizationOperationFilter>();
            });

            services.AddBRBAuthentication();

            services.AddBRBAuthorization();

            services.AddCors(options =>
            {
                options.AddPolicy("default", policy =>
                {
                    policy.AllowAnyHeader();
                    policy.AllowAnyMethod();
                    policy.AllowAnyOrigin();
                });
            });

            services.AddSingleton<ITranslationService, TranslationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseExceptionMiddelware();

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "BRbMicrosite Api Adapter");
                c.RoutePrefix = string.Empty;
            });

            app.UseCors("default");

            app.UseRouting();

            app.UseAuthentication();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
