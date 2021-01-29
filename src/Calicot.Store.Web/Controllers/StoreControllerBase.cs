using Abp.AspNetCore.Mvc.Controllers;

namespace Calicot.Store.Web.Controllers
{
    public abstract class StoreControllerBase: AbpController
    {
        protected StoreControllerBase()
        {
            LocalizationSourceName = StoreConsts.LocalizationSourceName;
        }
    }
}