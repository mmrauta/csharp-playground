namespace Algorithms.Grids
{
    public class Grid
    {
        /*
         * [[2,1,1],[1,1,0],[0,1,1]]
         */
        public static int[,] BuildGridOne()
        {
            return new [,]{ {2,1,1},{1,1,0},{0,1,1} };
        }

        /*
         * [[2,0,0],[0,0,0],[0,1,1]]
         */
        public static int[,] BuildGridTwo()
        {
            return new[,] { { 2,0,0 }, {0,0,0}, {0,1,1} };
        }
    }
}
