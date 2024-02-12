using System.Collections.Generic;
using AspnetBoilerplate.Demo.Roles.Dto;

namespace AspnetBoilerplate.Demo.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}