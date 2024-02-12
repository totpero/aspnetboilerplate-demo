using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AspnetBoilerplate.Demo.Localization
{
    public static class DemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DemoLocalizationConfigurer).GetAssembly(),
                        "AspnetBoilerplate.Demo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
