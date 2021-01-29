using Calicot.Store.EntityFrameworkCore;

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
            //create test data here...
        }
    }
}