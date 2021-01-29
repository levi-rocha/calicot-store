using Microsoft.EntityFrameworkCore;

namespace Calicot.Store.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<StoreDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for StoreDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
