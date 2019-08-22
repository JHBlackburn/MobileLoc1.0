using MobileLoc.Automotive.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MobileLoc.Automotive.Test.Persistence.Repositories
{
    public class DataScrapeRepositoryTests
    {
        [Fact]
        public void SpreadsheetTest_GivenHardcodedStuff_ReturnsValueOfCell()
        {
            var dataScrapeRepo = new DataScrapeRepository();

            dataScrapeRepo.SpreadsheetTest();
        }
    }
}