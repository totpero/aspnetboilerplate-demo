using System;
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AspnetBoilerplate.Demo.Tests2.Dto;

namespace AspnetBoilerplate.Demo.Tests.Dto;

public class TestResutDto:EntityDto
{
    public DateTime TestDate { get; set; }

    public IEnumerable<ISubItem> SubItems { get; set; }
}