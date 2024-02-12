using Abp.Authorization;
using AspnetBoilerplate.Demo.Authorization.Roles;
using AspnetBoilerplate.Demo.Authorization.Users;

namespace AspnetBoilerplate.Demo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
