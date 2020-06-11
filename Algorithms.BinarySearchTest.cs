using Algorithms;
using Xunit;

namespace csharp_playground.Algorithms
{
    public class BinarySearchTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        public void FindsAnItem(int searchedValue)
        {
            var someArray = new []{1, 2, 3, 4, 5};
            var itemFound = BinarySearch.BinarySearchRecursive(searchedValue, someArray);
            var itemFoundIteratively = BinarySearch.BinarySearchIterative(searchedValue, someArray);

            Assert.True(itemFound);
            Assert.True(itemFoundIteratively);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(7)]
        [InlineData(3)]
        public void IndicatesWhenNoItemFound(int searchedValue)
        {
            var someArray = new[] { 1, 2, 5, 6 };
            var itemFound = BinarySearch.BinarySearchRecursive(searchedValue, someArray);
            var itemFoundIteratively = BinarySearch.BinarySearchIterative(searchedValue, someArray);

            Assert.False(itemFound);
            Assert.False(itemFoundIteratively);
        }

        [Fact]
        public void DealsFineWithEmptyInput()
        {
            var itemFoundInNullArray = BinarySearch.BinarySearchRecursive(5, null);
            var itemFoundInEmptyArray = BinarySearch.BinarySearchRecursive(5, new int[] {});

            Assert.False(itemFoundInNullArray);
            Assert.False(itemFoundInEmptyArray);
        }
    }
}
