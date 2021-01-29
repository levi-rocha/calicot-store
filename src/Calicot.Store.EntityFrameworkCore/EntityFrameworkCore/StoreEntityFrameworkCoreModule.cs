using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Calicot.Store.EntityFrameworkCore
{
    [DependsOn(
        typeof(StoreCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class StoreEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StoreEntityFrameworkCoreModule).GetAssembly());
        }
    }
}