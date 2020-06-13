using Algorithms.Grids;
using Xunit;

namespace csharp_playground.Algorithms
{
    public class RottingOrangesTest
    {
        [Fact]
        public void CalculatesTheRottingTime()
        {
            var input = Grid.BuildGridOne();
            var minutes = RottingOranges.HowManyMinutes(input);
            Assert.Equal(4, minutes);
        }

        [Fact]
        public void IndicatesNotRottenOranges()
        {
            var input = Grid.BuildGridTwo();
            var minutes = RottingOranges.HowManyMinutes(input);
            Assert.Equal(-1, minutes);
        }
    }
}
