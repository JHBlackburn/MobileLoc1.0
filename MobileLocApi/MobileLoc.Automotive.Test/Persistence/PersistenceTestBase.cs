using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer;
using MobileLoc.Automotive.Test.TestBaseUtilities;

namespace MobileLoc.Automotive.Test.Persistence
{
    public class PersistenceTestBase
    {
        public MobilelocContext TestMobileLocContext;

        public PersistenceTestBase()
        {
            TestMobileLocContext = CreateInMemoryTestDb();
            var testData = new MobileLocDbTestData(TestMobileLocContext);
            testData.Initialize();
        }

        private MobilelocContext CreateInMemoryTestDb()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            var options = new DbContextOptionsBuilder<MobilelocContext>()
                .UseSqlite(connection)
                .Options;

            var context = new MobilelocContext(options);
            context.Database.EnsureCreated();

            return context;
        }
    }
}