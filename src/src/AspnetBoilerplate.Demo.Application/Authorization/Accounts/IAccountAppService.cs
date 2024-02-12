using System.Threading.Tasks;
using Abp.Application.Services;
using AspnetBoilerplate.Demo.Authorization.Accounts.Dto;

namespace AspnetBoilerplate.Demo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
