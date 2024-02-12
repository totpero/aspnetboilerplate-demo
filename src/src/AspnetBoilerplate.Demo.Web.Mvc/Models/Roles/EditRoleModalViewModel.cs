using Abp.AutoMapper;
using AspnetBoilerplate.Demo.Roles.Dto;
using AspnetBoilerplate.Demo.Web.Models.Common;

namespace AspnetBoilerplate.Demo.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
