using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Calicot.Store.Configuration;
using Calicot.Store.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace Calicot.Store.Web.Startup
{
    [DependsOn(
        typeof(StoreApplicationModule), 
        typeof(StoreEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class StoreWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public StoreWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(StoreConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<StoreNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(StoreApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StoreWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(StoreWebModule).Assembly);
        }
    }
}