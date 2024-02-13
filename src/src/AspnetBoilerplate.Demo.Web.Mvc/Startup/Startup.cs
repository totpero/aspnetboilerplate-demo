using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Castle.Facilities.Logging;
using Abp.AspNetCore;
using Abp.AspNetCore.Mvc.Antiforgery;
using Abp.Castle.Logging.Log4Net;
using AspnetBoilerplate.Demo.Authentication.JwtBearer;
using AspnetBoilerplate.Demo.Configuration;
using AspnetBoilerplate.Demo.Identity;
using AspnetBoilerplate.Demo.Web.Resources;
using Abp.AspNetCore.SignalR.Hubs;
using Abp.Json.SystemTextJson;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.WebEncoders;

namespace AspnetBoilerplate.Demo.Web.Startup
{
    public class Startup
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IConfigurationRoot _appConfiguration;

        public Startup(IWebHostEnvironment env)
        {
            _hostingEnvironment = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // MVC
            services.AddControllersWithViews(
                    options =>
                    {
                        options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                        options.Filters.Add(new AbpAutoValidateAntiforgeryTokenAttribute());
                    }
                )
                .AddRazorRuntimeCompilation()

                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                    options.JsonSerializerOptions.Converters.Add(new CultureInvariantDecimalJsonConverter());
                    options.JsonSerializerOptions.Converters.Add(new CultureInvariantNullableDecimalJsonConverter());
                    options.JsonSerializerOptions.Converters.Add(new CultureInvariantDoubleJsonConverter());
                    options.JsonSerializerOptions.Converters.Add(new CultureInvariantNullableDoubleJsonConverter());

                    options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());

                    options.JsonSerializerOptions.Converters.Add(new AbpNullableDateTimeConverter());
                    options.JsonSerializerOptions.Converters.Add(new AbpDateTimeConverter());
                })

                //.AddNewtonsoftJson(options =>
                //{
                //    options.SerializerSettings.ContractResolver = new AbpCamelCasePropertyNamesContractResolver();

                //    //@todo: the 9.0 old method
                //    //options.SerializerSettings.ContractResolver = new DefaultContractResolver
                //    //{
                //    //    NamingStrategy = new CamelCaseNamingStrategy()
                //    //};
                //    //options.SerializerSettings.Converters.Add(new OldDateTimeJsonConverter());

                //    options.SerializerSettings.Converters.Add(new CultureInvariantDecimalConverter());
                //    options.SerializerSettings.Converters.Add(new CultureInvariantDoubleConverter());

                //    options.SerializerSettings.Converters.Add(new DateOnlyJsonConverter());
                //    //options.SerializerSettings.Converters.Add(new DateOnlyNullableJsonConverter());

                //})
                ;

            IdentityRegistrar.Register(services);
            AuthConfigurer.Configure(services, _appConfiguration);

            services.Configure<WebEncoderOptions>(options =>
            {
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });

            services.AddScoped<IWebResourceManager, WebResourceManager>();

            services.AddSignalR();

            // Configure Abp and Dependency Injection
            services.AddAbpWithoutCreatingServiceProvider<DemoWebMvcModule>(
                // Configure Log4Net logging
                options => options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig(
                        _hostingEnvironment.IsDevelopment()
                            ? "log4net.config"
                            : "log4net.Production.config"
                        )
                )
            );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseAbp(); // Initializes ABP framework.

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseJwtTokenMiddleware();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<AbpCommonHub>("/signalr");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("defaultWithArea", "{area}/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
