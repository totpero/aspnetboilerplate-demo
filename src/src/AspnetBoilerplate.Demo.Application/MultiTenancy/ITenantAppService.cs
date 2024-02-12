using Abp.Application.Services;
using AspnetBoilerplate.Demo.MultiTenancy.Dto;

namespace AspnetBoilerplate.Demo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

