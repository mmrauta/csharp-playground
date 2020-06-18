using System;

namespace Algorithms.Sort
{
    /// <summary>
    /// QuickSort is an in-place algorithm/
    /// Time complexity:
    ///     O(nlogn) - average case
    ///     O(n^2) - worst case
    /// </summary>
    public static class QuickSort
    {
        public static int[] Run(int[] array)
        {
            if (array is null)
                return new int[]{};

            if (array.Length == 1)
                return array;

            return Sort(array, 0, array.Length - 1);
        }

        private static int[] Sort(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int pivotIndex = Partition(array, leftIndex, rightIndex);
                Sort(array, leftIndex, pivotIndex - 1);
                Sort(array, pivotIndex + 1, rightIndex);
            }

            return array;
        }

        /// <summary>
        /// Partitions the collection by selecting random pivot item.
        /// Ensures items lower then pivot are on the left and bigger items are on the right from pivot.
        /// </summary>
        /// <returns>pivot index</returns>
        private static int Partition(int[] array, int leftIndex, int rightIndex)
        {
            var pivotValue = SetPivotOnLeftIndex(array, leftIndex, rightIndex);     // pivot value is now in the leftIndex position

            var partitionIndex = leftIndex + 1;                 // partitionIndex always points just after the last item lower (or equal to) pivot

            for (var i = leftIndex + 1; i <= rightIndex; i++)   // iterator and partitionIndex start at the same position (one after the pivot)
                if (array[i] <= pivotValue)                     // if current item is lower than pivot value
                {
                    Swap(array, i, partitionIndex);             // move current item just after the last item lower (or equal to) pivot
                    partitionIndex++;                           // we have 1 more item on the left, so we have to move partitionIndex by 1 position
                }

            Swap(array, leftIndex, partitionIndex - 1);         // swap the last lower then pivot item with the pivot value
            return partitionIndex - 1;                          // return index of the pivot value
        }

        /// <summary>
        /// Finds pivot value (random item within a range) and sets it as first in an array
        /// </summary>
        /// <returns>pivot value</returns>
        private static int SetPivotOnLeftIndex(int[] array, int leftIndex, int rightIndex)
        {
            var pivotIndex = GetRandomIndex(leftIndex, rightIndex);
            var pivotValue = array[pivotIndex];
            Swap(array, leftIndex, pivotIndex);
            return pivotValue;
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            if (index1 == index2)
                return;

            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        private static int GetRandomIndex(int leftIndex, int rightIndex)
        {
            var random = new Random();
            var pivotiIndex = random.Next(leftIndex, rightIndex);
            return pivotiIndex;
        }
    }
}
