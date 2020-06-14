using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Grids
{
    public class SpiralMatrix
    {
        public static List<int> GetSpiral(int[][] matrix)
        {
            var result = new List<int>();
            if (matrix == null || !matrix.Any())
                return result;

            var top = 0;
            var right = matrix[0].Length - 1;
            var left = 0;
            var bottom = matrix.Length - 1;

            var totalLength = matrix[0].Length * matrix.Length;
            while (result.Count < totalLength)
            {
                for (var i = left; i <= right && result.Count < totalLength; i++)
                    result.Add(matrix[top][i]);
                top++;

                for (var i = top; i <= bottom && result.Count < totalLength; i++)
                    result.Add(matrix[i][right]);
                right--;

                for (var i = right; i >= left && result.Count < totalLength; i--)
                    result.Add(matrix[bottom][i]);
                bottom--;

                for (var i = top; i >= top && result.Count < totalLength; i--)
                    result.Add(matrix[i][left]);
                left++;
            }

            return result;
        }
    }
}
