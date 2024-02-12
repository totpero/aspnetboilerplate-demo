using System.Collections.Generic;
using AspnetBoilerplate.Demo.Roles.Dto;

namespace AspnetBoilerplate.Demo.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
