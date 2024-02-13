using System;
using Abp.Application.Services;
using AspnetBoilerplate.Demo.Tests.Dto;

namespace AspnetBoilerplate.Demo.Tests;

public interface ITest2AppService: IApplicationService
{
    TestResutDto TestMethod();
}