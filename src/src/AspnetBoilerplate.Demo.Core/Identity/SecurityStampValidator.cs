using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using AspnetBoilerplate.Demo.Authorization.Roles;
using AspnetBoilerplate.Demo.Authorization.Users;
using AspnetBoilerplate.Demo.MultiTenancy;
using Microsoft.Extensions.Logging;
using Abp.Domain.Uow;

namespace AspnetBoilerplate.Demo.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ILoggerFactory loggerFactory,
            IUnitOfWorkManager unitOfWorkManager)
            : base(options, signInManager, loggerFactory, unitOfWorkManager)
        {
        }
    }
}
