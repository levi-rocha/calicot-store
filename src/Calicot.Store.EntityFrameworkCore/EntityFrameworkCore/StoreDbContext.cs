using Abp.EntityFrameworkCore;
using Calicot.Store.Products;
using Microsoft.EntityFrameworkCore;

namespace Calicot.Store.EntityFrameworkCore
{
    public class StoreDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Product> Products { get; set; }

        public StoreDbContext(DbContextOptions<StoreDbContext> options) 
            : base(options)
        {

        }
    }
}
