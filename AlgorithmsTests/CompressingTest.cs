using Algorithms.Strings;
using Xunit;

namespace csharp_playground.AlgorithmsTests
{
    public class CompressingTest
    {
        [Theory]
        [InlineData("aaabbbb", "a3b4")]
        [InlineData("a", "a")]
        [InlineData("abbbbcdd", "ab4cd2")]
        public void CompressesString(string input, string expected)
        {
            var result = Compressing.Run(input);
            Assert.Equal(expected, result);
        }
    }
}
