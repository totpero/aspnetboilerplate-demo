using Abp.AutoMapper;
using AspnetBoilerplate.Demo.Sessions.Dto;

namespace AspnetBoilerplate.Demo.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
