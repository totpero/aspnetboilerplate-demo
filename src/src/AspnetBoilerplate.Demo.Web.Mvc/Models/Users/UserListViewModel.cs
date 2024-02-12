using System.Collections.Generic;
using AspnetBoilerplate.Demo.Roles.Dto;

namespace AspnetBoilerplate.Demo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
