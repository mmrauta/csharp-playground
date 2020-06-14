namespace Algorithms.Grids
{
    public class Grid
    {
        /*
         * [[2,1,1],[1,1,0],[0,1,1]]
         */
        public static int[,] BuildGridOne()
        {
            return new[,] {{2, 1, 1}, {1, 1, 0}, {0, 1, 1}};
        }

        /*
         * [[2,0,0],[0,0,0],[0,1,1]]
         */
        public static int[,] BuildGridTwo()
        {
            return new[,] {{2, 0, 0}, {0, 0, 0}, {0, 1, 1}};
        }

        /*[
         * [1,2,3],
         * [8,9,4],
         * [7,6,5]
         * ]
         */
        public static int[][] BuildJaggedGridOne()
        {
            return new int[][] {new[] {1, 2, 3}, new[] {8, 9, 4}, new[] {7, 6, 5}};
        }

        /*[
         * [1,2,3,4],
         * [1,2,3,5],
         * [9,8,7,6]
         * ]
         */
        public static int[][] BuildJaggedGridTwo()
        {
            return new int[][] { new[] { 1, 2, 3, 4 }, new[] { 1,2,3,5 }, new[] { 9,8,7,6} };
        }
    }
}
