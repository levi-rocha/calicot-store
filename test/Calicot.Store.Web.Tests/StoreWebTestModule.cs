using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Calicot.Store.Web.Startup;
namespace Calicot.Store.Web.Tests
{
    [DependsOn(
        typeof(StoreWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class StoreWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StoreWebTestModule).GetAssembly());
        }
    }
}