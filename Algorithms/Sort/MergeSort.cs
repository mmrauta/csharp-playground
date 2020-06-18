using System.Linq;

namespace Algorithms.Sort
{
    /// <summary>
    /// Time complexity: O(nlogn)
    /// </summary>
    public static class MergeSort
    {
        public static int[] Run(int[] numbers)
        {
            if (numbers == null || !numbers.Any())
                return new int[] { };

            if (numbers.Length == 1)
                return numbers;

            return Sort(numbers);
        }

        private static int[] Sort(int[] numbers)
        {
            if (numbers.Length <= 1)
                return numbers;

            var (left, right) = SplitHalf(numbers);

            var leftSorted = Sort(left);
            var rightSorted = Sort(right);

            return Merge(leftSorted, rightSorted);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            var totalLength = left.Length + right.Length;
            var result = new int[totalLength];

            for (int iResult = 0, iLeft = 0, iRight = 0; iResult < totalLength; iResult++)
            {
                if (TableEndReached(left, iLeft))
                    return AppendItems(result, iResult, right[iRight..]);

                if (TableEndReached(right, iRight))
                    return AppendItems(result, iResult, left[iLeft..]);

                result[iResult] = left[iLeft] < right[iRight]
                                ? left[iLeft++]
                                : right[iRight++];
            }

            return result;
        }

        private static bool TableEndReached(int[] set, int index)
            => set.Length == index;

        private static (int[], int[]) SplitHalf(this int[] set)
        {
            var length = set.Length / 2;
            return (set[..length], set[length..]);
        }

        /// <summary>
        /// Inserts all provided items to the result array, starting at the specified position
        /// </summary>
        private static int[] AppendItems(int[] result, int startIndex, int[] items)
        {
            for (int i = startIndex, j = 0; i < result.Length; i++, j++)
                result[i] = items[j];

            return result;
        }
    }
}
