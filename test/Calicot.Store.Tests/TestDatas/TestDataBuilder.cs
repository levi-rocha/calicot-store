using Calicot.Store.EntityFrameworkCore;
using Calicot.Store.Products;

namespace Calicot.Store.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly StoreDbContext _context;

        public TestDataBuilder(StoreDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.Products.AddRange(
            new Product("Product 1", "A product!", 3.50m),
            new Product("Product 2", "Another product!", 3.50m)
            );
        }
    }
}