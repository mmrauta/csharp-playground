using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Miscellaneous
{
    /// <summary>
    /// Get K closest points to the origin (0,0)
    /// </summary>
    public static class KClosestPointsToOrigin
    {
        public static int[][] GetKClosest(int[][] points, int k)
        {
            if (points == null || !points.Any())
                return new int[][]{};

            var pointsDistances = new List<(int distance, int[] point)>();

            foreach (var point in points)
            {
                var distance = (int)Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
                pointsDistances.Add((distance, point));
            }

            pointsDistances.Sort(PointsDistanceComparator);

            var kTop = pointsDistances
                            .Take(k)
                            .Select(x => x.point)
                            .ToArray();
            return kTop;
        }

        public static int[,] GetKClosest(int[,] points, int k)
        {
            if (points == null || points.Length == 0)
                return new int[,] { };

            var pointsDistances = new List<(int distance, int[] point)>();

            var pointsCollection = new List<int[]>();
            for (var i = 0; i < points.GetLength(0); i++)
                pointsCollection.Add(Helpers<int>.GetRow(points, i));
            
            foreach (var point in pointsCollection)
            {
                var distance = (int)Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
                pointsDistances.Add((distance, point));
            }

            var result = new int[k, 2];

            pointsDistances.Sort(PointsDistanceComparator);

            var kTop = pointsDistances
                .Take(k)
                .Select(x => x.point)
                .ToArray();

            for (var i = 0; i < k; i++)
            {
                result[i, 0] = kTop[i][0];
                result[i, 1] = kTop[i][1];
            }

            return result;
        }

        private static int PointsDistanceComparator((int distance, int[] point) one, (int distance, int[] point) two)
        {
            if (one.distance == two.distance)
                return 0;
            if (one.distance > two.distance)
                return 1;
            return -1;
        }
    }
}
