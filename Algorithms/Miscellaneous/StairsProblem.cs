namespace Algorithms.Miscellaneous
{
    public static class StairsProblem
    {
        /// <summary>
        /// Get number of ways in which you can climb the n steps using only steps lengths from a provided stepsLengths array.
        /// </summary>
        /// <param name="stepsHeight">number of steps to climb (height of the stairs)</param>
        /// <param name="stepsLengths">possible steps lengths (how many steps we can jump in one move)</param>
        /// <returns>Number of possible steps combinations</returns>
        public static int GetNumberOfWays(int stepsHeight, int[] stepsLengths)
        {
            if (stepsHeight == 0)
                return 1;

            var cache = new int[stepsHeight+1];
            cache[0] = 1;

            for (int level = 1; level <= stepsHeight; level++)
            {
                var total = 0;
                foreach (var stepLength in stepsLengths)
                    if (level - stepLength >= 0)
                        total += cache[level - stepLength];

                cache[level] = total;
            }

            return cache[stepsHeight];
        }
    }
}
