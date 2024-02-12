using System;
using Abp.Application.Services.Dto;

namespace AspnetBoilerplate.Demo.Tests.Dto;

public class TestInputDto:EntityDto
{
    public DateTime TestDate { get; set; }
}