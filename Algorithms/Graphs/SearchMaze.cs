using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Graphs
{
    public class SearchMaze
    {
        private static List<(int x, int y)> directions = new List<(int x, int y)> {(0, 1), (0, -1), (1, 0), (-1, 0)};

        public static bool HasExit(char[,] given)
        {
            var rows = given.GetLength(0);
            var columns = given.GetLength(1);

            var queue = new Queue<(int x, int y)> ();
            var visited = new HashSet<(int x, int y)> ();

            queue.Enqueue((0,0));

            while (queue.Any())
            {
                var current = queue.Dequeue();
                if (given[current.x, current.y] == 'E')
                    return true;

                if (!visited.Contains(current))
                    visited.Add(current);

                foreach (var direction in directions)
                {
                    var newPosition = (current.x + direction.x, current.y + direction.y);
                    if (CanMove(given, newPosition, rows, columns) && !visited.Contains(newPosition))
                        queue.Enqueue(newPosition);
                }
            }

            return false;
        }

        private static bool CanMove(char[,] given, (int x, int y) point, int rows, int columns)
        {
            var inTheGrid = point.x < rows && point.x >= 0 && point.y < columns && point.y >= 0;
            if (!inTheGrid)
                return false;

            var cellContent = given[point.x, point.y];
            return cellContent != 'X';
        }
    }
}
