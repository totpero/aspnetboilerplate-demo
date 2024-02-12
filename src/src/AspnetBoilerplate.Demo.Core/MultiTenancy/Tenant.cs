using Abp.MultiTenancy;
using AspnetBoilerplate.Demo.Authorization.Users;

namespace AspnetBoilerplate.Demo.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
