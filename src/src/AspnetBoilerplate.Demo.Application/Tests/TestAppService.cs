using System;
using AspnetBoilerplate.Demo.Tests.Dto;

namespace AspnetBoilerplate.Demo.Tests;

public class TestAppService: DemoAppServiceBase, ITestAppService
{
    public DateTime TestMethod(TestInputDto input)
    {
        return input.TestDate;
    }
}