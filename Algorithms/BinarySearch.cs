using System.Linq;

namespace Algorithms
{
    /// <summary>
    /// REMARK: Input for the binary search algorithm must be sorted!
    /// Time complexity is the O(log_2(n)) - how many times do we need to divide the n elements by 2 to end up with 1 final element?
    /// </summary>
    public static class BinarySearch
    {
        public static bool BinarySearchRecursive(int searchedNumber, int[] array)
        {
            if (array == null || !array.Any()) 
                return false;

            return BinarySearchRecursive(searchedNumber, array, 0, array.Length - 1);
        }

        public static bool BinarySearchIterative(int searchedNumber, int[] array)
        {
            if (array == null || !array.Any())
                return false;

            return BinarySearchIterative(searchedNumber, array, 0, array.Length - 1);
        }

        /// <summary>
        /// Searches for an element within a sorted array using recursion.
        /// </summary>
        /// <param name="searchedNumber">The value we are trying to find</param>
        /// <param name="array">Array in which we are searching</param>
        /// <param name="left">Index of the currently most left element</param>
        /// <param name="right">Index of the currently most right element</param>
        /// <returns>[true] if element was found, [false] otherwise</returns>
        private static bool BinarySearchRecursive(int searchedNumber, int[] array, int left, int right)
        {
            if (left > right)
            {
                return false;
            }

            var midPointIndex = (left + right) / 2;
            var midPointValue = array[midPointIndex];

            if (midPointValue == searchedNumber)
            {
                return true;
            }
            
            return searchedNumber < midPointValue
                ? BinarySearchRecursive(searchedNumber, array, left, midPointIndex - 1)
                : BinarySearchRecursive(searchedNumber, array, midPointIndex + 1, right);

        }

        /// <summary>
        /// Searches for an element within a sorted array using iterative logic.
        /// </summary>
        /// <param name="searchedNumber">The value we are trying to find</param>
        /// <param name="array">Array in which we are searching</param>
        /// <param name="left">Index of the currently most left element</param>
        /// <param name="right">Index of the currently most right element</param>
        /// <returns>[true] if element was found, [false] otherwise</returns>
        private static bool BinarySearchIterative(int searchedNumber, int[] array, int left, int right)
        {
            while (left <= right)
            {
                var midPointIndex = (left + right) / 2;
                var midPointValue = array[midPointIndex];

                if (midPointValue == searchedNumber)
                {
                    return true;
                }

                if (searchedNumber < midPointValue)
                {
                    right = midPointIndex - 1;
                }
                else
                {
                    left = midPointIndex + 1;
                }
            }

            return false;
        }
    }
}
