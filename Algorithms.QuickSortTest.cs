using Algorithms.Sort;
using Xunit;

namespace csharp_playground.Algorithms
{
    public class QuickSortTest
    {

        [Fact]
        public void SortsItems()
        {
            var input = new[] { 7, 6, 5, 4, 3, 2, 1, 0 };
            var sorted = QuickSort.Sort(input);
            Assert.Equal(new[] { 0, 1, 2, 3, 4, 5, 6, 7 }, sorted);
        }
    }
}
