using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AspnetBoilerplate.Demo.Configuration.Dto;

namespace AspnetBoilerplate.Demo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
