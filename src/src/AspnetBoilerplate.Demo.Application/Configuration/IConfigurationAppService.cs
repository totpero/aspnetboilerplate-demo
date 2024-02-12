using System.Threading.Tasks;
using AspnetBoilerplate.Demo.Configuration.Dto;

namespace AspnetBoilerplate.Demo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
