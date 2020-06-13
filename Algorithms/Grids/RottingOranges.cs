using System.Collections.Generic;

namespace Algorithms.Grids
{
    public static class RottingOranges
    {
        public static int HowManyMinutes(int[,] grid)
        {
            var fresh = new HashSet<(int x, int y)>();
            var rotten= new HashSet<(int x, int y)>();
            for (int i = 0; i < grid.GetLength(0); i++)
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i,j] == 1)
                        fresh.Add((i, j));
                    else if (grid[i,j] == 2)
                        rotten.Add((i, j));

                }

            var minutes = 0;
            var directions = new (int x, int y)[] {(0,1), (1,0), (-1,0), (0,-1)};
            while (fresh.Count > 0)
            {
                var infected = new HashSet<(int x, int y)>();
                foreach (var item in rotten)
                    foreach (var direction in directions)
                    {
                        var newIndices = (item.x + direction.x, item.y + direction.y);
                        if (fresh.Contains(newIndices))
                        {
                            fresh.Remove(newIndices);
                            infected.Add(newIndices);
                        }
                    }

                if (infected.Count == 0)    // there are fresh oranges but none infected
                    return -1;

                rotten = infected;          // we can override the previously rotten
                                            // as they've already infected everything they could
                minutes++;
            }

            return minutes;
        }
    }
}
