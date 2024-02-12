using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspnetBoilerplate.Demo.Configuration;

namespace AspnetBoilerplate.Demo.Web.Host.Startup
{
    [DependsOn(
       typeof(DemoWebCoreModule))]
    public class DemoWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DemoWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DemoWebHostModule).GetAssembly());
        }
    }
}
