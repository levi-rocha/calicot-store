using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Calicot.Store.EntityFrameworkCore
{
    public class StoreDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public StoreDbContext(DbContextOptions<StoreDbContext> options) 
            : base(options)
        {

        }
    }
}
