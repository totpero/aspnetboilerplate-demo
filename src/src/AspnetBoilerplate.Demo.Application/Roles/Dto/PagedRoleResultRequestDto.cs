﻿using Abp.Application.Services.Dto;

namespace AspnetBoilerplate.Demo.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

