using Algorithms.Miscellaneous;
using Xunit;

namespace csharp_playground.AlgorithmsTests
{
    public class KClosestPointsToOriginTest
    {
        [Fact]
        public void FindsKClosestPoints()
        {
            var input = new int[][] {new []{1,4}, new[] { 2,3}, new[] { 5,6}, new[] { 1,7}};
            var closest = KClosestPointsToOrigin.GetKClosest(input, 2);
            Assert.Equal(new int[][]{ new[] {2,3}, new[] {1,4}}, closest);
        }

        [Fact]
        public void FindsKClosestPointsUsing2DArray()
        {
            var input = new int[,] { { 1, 4 }, { 2, 3 }, { 5, 6 }, { 1, 7 } };
            var closest = KClosestPointsToOrigin.GetKClosest(input, 2);
            Assert.Equal(new int[,]{{2,3},{1,4} }, closest);
        }

        [Fact]
        public void DealsWithEmptyInputs()
        {
            var closestOne = KClosestPointsToOrigin.GetKClosest(new int[,] { }, 2);
            var closestTwo = KClosestPointsToOrigin.GetKClosest(new int[][] { }, 2);

            Assert.Empty(closestOne);
            Assert.Empty(closestTwo);
        }
    }
}
