using System;
using Abp.Application.Services;
using AspnetBoilerplate.Demo.Tests.Dto;

namespace AspnetBoilerplate.Demo.Tests;

public interface ITestAppService: IApplicationService
{
    DateTime TestMethod(TestInputDto input);
}