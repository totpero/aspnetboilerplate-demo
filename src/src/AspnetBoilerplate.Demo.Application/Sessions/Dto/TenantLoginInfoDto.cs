using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AspnetBoilerplate.Demo.MultiTenancy;

namespace AspnetBoilerplate.Demo.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
