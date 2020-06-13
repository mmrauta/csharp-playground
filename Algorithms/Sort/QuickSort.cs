using System;

namespace Algorithms.Sort
{
    /// <summary>
    /// O(nlogn) - average case running time
    /// O(n^2) - worst case running time
    /// In-place algorithm
    /// </summary>
    public static class QuickSort
    {
        public static int[] Sort(int[] array)
        {
            if (array is null)
                return new int[]{};

            if (array.Length == 1)
                return array;

            return Sort(array, 0, array.Length - 1);
        }

        public static int[] Sort(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)                         // there is at least one item between right and left index
            {
                int pivotIndex = Partition(array, leftIndex, rightIndex);
                Sort(array, leftIndex, pivotIndex - 1);
                Sort(array, pivotIndex+1, rightIndex);
            }

            return array;
        }

        /// <summary>
        /// Partitions the collection by selecting random pivot item
        /// </summary>
        /// <param name="array">input array</param>
        /// <param name="leftIndex">start index of the elements to partitions</param>
        /// <param name="rightIndex">end index of the elements to partitions</param>
        /// <returns>partition index</returns>
        private static int Partition(int[] array, int leftIndex, int rightIndex)
        {
            var pivotIndex = GetPivotIndex(leftIndex, rightIndex);
            var pivotValue = array[pivotIndex];

            Swap(array, leftIndex, pivotIndex);         // now pivot value is at the beginning of the array
            var partitionIndex = leftIndex + 1;                 // start testing each element after the pivot value
            for (var i = partitionIndex; i <= rightIndex; i++)
            {
                if (array[i] <= pivotValue)                         // if current item is lower than pivot item
                {
                    Swap(array, i, partitionIndex);
                    partitionIndex++;
                }
            }

            Swap(array, leftIndex, partitionIndex-1);  // swap last lower then pivot item with the pivot value
            return partitionIndex-1; 
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            if (index1 == index2)
                return;

            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        private static int GetPivotIndex(int leftIndex, int rightIndex)
        {
            var random = new Random();
            var pivotiIndex = random.Next(leftIndex, rightIndex);
            return pivotiIndex;
        }
    }
}
