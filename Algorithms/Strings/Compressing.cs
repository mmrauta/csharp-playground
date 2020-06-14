using System.Linq;

namespace Algorithms.Strings
{
    public class Compressing
    {
        public static string Run(string input)
        {
            var chars = input.ToCharArray(); 
            var index = 0;                                          // index will follow the newly entered data
            var i = 0;

            while (i < chars.Length)
            {
                var j = i;
                while (j < chars.Length && chars[j] == chars[i])    // move as long as you're finding the same character 
                    j++;

                chars[index++] = chars[i];                          // enter the letter
                if (j - i > 1)                                      // distance between current char and it's last duplicate
                {
                    var count = (j - i).ToString();
                    foreach (var digit in count)                // each digit must be saved in a separate cell
                        chars[index++] = digit;
                }

                i = j;
            }

            var compressedPart = chars.Take(index);
            var result = string.Join(string.Empty, compressedPart);
            return result;
        }
    }
}
