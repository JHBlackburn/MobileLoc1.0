using MobileLoc.Automotive.Domain.Queries;
using System;
using System.Threading.Tasks;
using Xunit;

namespace MobileLoc.Automotive.Test.Domain.Queries
{
    public class GetYearsTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public async Task Constructor_GivenNoModelId_ThrowsArgumentException(int initializedModelId)
        {
            // act and assert
            var exception = Assert.Throws<ArgumentException>(() => new GetYears(initializedModelId));
        }
    }
}