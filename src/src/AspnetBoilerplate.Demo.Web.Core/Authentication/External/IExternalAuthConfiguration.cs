using System.Collections.Generic;

namespace AspnetBoilerplate.Demo.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
