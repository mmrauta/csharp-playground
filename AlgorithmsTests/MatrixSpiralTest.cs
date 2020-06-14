using Algorithms.Grids;
using Xunit;

namespace csharp_playground.AlgorithmsTests
{
    public class MatrixSpiralTest
    {
        [Fact]
        public void GetsSpiral()
        {
            var input = Grid.BuildJaggedGridOne();
            var result = SpiralMatrix.GetSpiral(input);
            Assert.Equal("123456789", string.Join(string.Empty, result));

            var inputTwo = Grid.BuildJaggedGridTwo();
            var resultTwo = SpiralMatrix.GetSpiral(inputTwo);
            Assert.Equal("123456789123", string.Join(string.Empty, resultTwo));
        }
    }
}
