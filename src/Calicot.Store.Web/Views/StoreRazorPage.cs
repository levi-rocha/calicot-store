using Abp.AspNetCore.Mvc.Views;

namespace Calicot.Store.Web.Views
{
    public abstract class StoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected StoreRazorPage()
        {
            LocalizationSourceName = StoreConsts.LocalizationSourceName;
        }
    }
}
