using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Calicot.Store.EntityFrameworkCore;
using Calicot.Store.Tests.TestDatas;

namespace Calicot.Store.Tests
{
    public class StoreTestBase : AbpIntegratedTestBase<StoreTestModule>
    {
        public StoreTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<StoreDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<StoreDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<StoreDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<StoreDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<StoreDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<StoreDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<StoreDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<StoreDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
