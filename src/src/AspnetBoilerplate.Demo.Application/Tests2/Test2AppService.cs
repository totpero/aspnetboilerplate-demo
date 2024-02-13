using System;
using AspnetBoilerplate.Demo.Tests.Dto;
using AspnetBoilerplate.Demo.Tests2.Dto;

namespace AspnetBoilerplate.Demo.Tests;

public class Test2AppService: DemoAppServiceBase, ITest2AppService
{
    public TestResutDto TestMethod()
    {
        var result = new TestResutDto
        {
            Id = 1,
            TestDate = DateTime.Now,
            SubItems = new ISubItem[] { 
                new SubItemModel1 { 
                    Prop1 = 1,
                    Prop2 = true, 
                    PropModel1Prop1 = 100, 
                    PropModel1Prop2 = false
                },
                new SubItemModel2 {
                    Prop1 = 2,
                    Prop2 = false,
                    PropModel2Prop1 = 200,
                    PropModel2Prop2 = true
                }
            }
        };
        return result;
    }
}