using Algorithms.Sort;
using Xunit;

namespace csharp_playground.AlgorithmsTests
{
    public class QuickSortTest
    {
        [Theory]
        [InlineData(new[] { 7, 6, 5, 4, 3, 2, 1, 0 }, new[] { 0, 1, 2, 3, 4, 5, 6, 7 })]
        [InlineData(new[] { 7, 3 }, new[] { 3, 7 })]
        [InlineData(new[] { 1 }, new[] { 1 })]
        [InlineData(new[] { 7, 3, 101 }, new[] { 3, 7, 101 })]
        [InlineData(new int[] { }, new int [] { })]
        [InlineData(null, new int[] { })]
        public void SortsItems(int[] input, int[] expected)
        {
            var sorted = QuickSort.Run(input);
            Assert.Equal(expected, sorted);
        }
    }
}
