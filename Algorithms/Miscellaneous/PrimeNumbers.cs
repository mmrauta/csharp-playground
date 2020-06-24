namespace Algorithms.Miscellaneous
{
    public static class PrimeNumbers
    {
        /// Time Complexity: O(sqrt(n))
        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            
            for (var i = 2; i*i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
