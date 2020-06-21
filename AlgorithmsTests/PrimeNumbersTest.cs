using Algorithms.Miscellaneous;
using Xunit;

namespace csharp_playground.AlgorithmsTests
{
    public class PrimeNumbersTest
    {
        [Theory]
        [InlineData(1, false)]
        [InlineData(-10, false)]
        [InlineData(2, true)]
        [InlineData(11, true)]
        [InlineData(33, false)]
        [InlineData(50, false)]
        public void KnowsIfNumberIsPrimeNumber(int input, bool expected)
        {
            var result = PrimeNumbers.IsPrime(input);
            Assert.Equal(expected, result);
        }
    }
}
