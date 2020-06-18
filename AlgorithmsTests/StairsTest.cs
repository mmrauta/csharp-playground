using Algorithms.Miscellaneous;
using Xunit;

namespace csharp_playground.AlgorithmsTests
{
    public class StairsTest
    {
        [Fact]
        public void FindsNumberOfWays()
        {
            var numberOfWays= StairsProblem.GetNumberOfWays(5, new []{1,3});
            Assert.Equal(4, numberOfWays);
        }
    }
}
