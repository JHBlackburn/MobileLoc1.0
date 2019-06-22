using MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer;
using MobileLoc.Automotive.Test.TestBaseUtilities;
using TestSupport.EfHelpers;

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
            var options = SqliteInMemory
                .CreateOptions<MobilelocContext>();

            return new MobilelocContext(options);
        }
    }
}