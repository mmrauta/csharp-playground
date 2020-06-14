namespace Algorithms.Miscellaneous
{
    public static class RobotReturningHome
    {
        public static bool HasReturned(string moves)
        {
            var upAndDown = 0;
            var rightAndLeft = 0;

            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'L':
                        rightAndLeft--;
                        break;
                    case 'R':
                        rightAndLeft++;
                        break;
                    case 'D':
                        upAndDown--;
                        break;
                    case 'U':
                        upAndDown++;
                        break;
                }
            }

            return upAndDown == 0 && rightAndLeft == 0;
        }
    }
}
