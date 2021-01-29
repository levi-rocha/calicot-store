using Abp.Application.Services;

namespace Calicot.Store
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class StoreAppServiceBase : ApplicationService
    {
        protected StoreAppServiceBase()
        {
            LocalizationSourceName = StoreConsts.LocalizationSourceName;
        }
    }
}