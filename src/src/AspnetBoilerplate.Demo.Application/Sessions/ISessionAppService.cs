using System.Threading.Tasks;
using Abp.Application.Services;
using AspnetBoilerplate.Demo.Sessions.Dto;

namespace AspnetBoilerplate.Demo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
