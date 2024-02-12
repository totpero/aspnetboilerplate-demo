﻿using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Security;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using AspnetBoilerplate.Demo.Authorization.Roles;
using AspnetBoilerplate.Demo.Authorization.Users;
using AspnetBoilerplate.Demo.Configuration;
using AspnetBoilerplate.Demo.Localization;
using AspnetBoilerplate.Demo.MultiTenancy;
using AspnetBoilerplate.Demo.Timing;

namespace AspnetBoilerplate.Demo
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class DemoCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            DemoLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = DemoConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            
            Configuration.Localization.Languages.Add(new LanguageInfo("ro", "Română", "famfamfam-flags ro"));


            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = DemoConsts.DefaultPassPhrase;
            SimpleStringCipher.DefaultPassPhrase = DemoConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DemoCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
