using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

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
            if (string.IsNullOrWhiteSpace(connectionString) || connectionString.ToLower() == "inmemory")
                dbContextOptions
                    .UseInMemoryDatabase("calicotdb")
                    .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning));
            else
                dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
