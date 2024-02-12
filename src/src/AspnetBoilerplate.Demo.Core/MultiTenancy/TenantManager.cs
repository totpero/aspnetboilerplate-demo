using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using AspnetBoilerplate.Demo.Authorization.Users;
using AspnetBoilerplate.Demo.Editions;

namespace AspnetBoilerplate.Demo.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
