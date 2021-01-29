using Abp.Modules;
using Abp.Reflection.Extensions;
using Calicot.Store.Localization;

namespace Calicot.Store
{
    public class StoreCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            StoreLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StoreCoreModule).GetAssembly());
        }
    }
}