using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Calicot.Store
{
    [DependsOn(
        typeof(StoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class StoreApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StoreApplicationModule).GetAssembly());
        }
    }
}