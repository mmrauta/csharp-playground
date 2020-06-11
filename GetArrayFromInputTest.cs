using System;
using System.Linq;
using Xunit;

namespace csharp_playground
{
    public class GetArrayFromInputTest
    {
        [Fact]
        public void GetArrayOfCharsFromString()
        {
            var arrayOfLetters = "my dog".ToCharArray();
            Assert.Equal(new[] { 'm', 'y', ' ', 'd', 'o', 'g' }, arrayOfLetters);
        }

        [Fact]
        public void GetArrayOfStringsFromString()
        {
            var arrayOfStrings = "0;11;abc;2;34".Split(";");
            Assert.Equal(new[] { "0", "11", "abc", "2", "34" }, arrayOfStrings);
        }

        [Fact]
        public void GetArrayOfDigitsFromNumber()
        {
            var arrayOfDigits = 123.ToString().Select(x => int.Parse(x.ToString()));
            var arrayOfDigits2 = "123".Select(x => int.Parse(x.ToString())).ToArray();

            Assert.Equal(new[] { 1, 2, 3 }, arrayOfDigits);
            Assert.Equal(new[] { 1, 2, 3 }, arrayOfDigits2);
        }

        [Fact]
        public void GetArrayOfBitsFromNumber()
        {
            var number = int.Parse("65");
            var asBinary = Convert.ToString(number, 2);
            var arrayOfBitsAsChars = asBinary.ToCharArray();
            var arrayOfBitsAsIntegers = arrayOfBitsAsChars.Select(x => int.Parse(x.ToString()));

            Assert.Equal("1000001", asBinary);
            Assert.Equal(new[] { '1','0', '0', '0', '0', '0', '1' }, arrayOfBitsAsChars);
            Assert.Equal(new[] { 1, 0, 0, 0, 0, 0, 1}, arrayOfBitsAsIntegers);
        }

        [Fact]
        public void EmptyArrayHasNoElements()
        {
            var array = new int[] { };      // creating empty array (of size 0) -> this is equivalent of: new int[0]
            Assert.Empty(array);
            Assert.Equal(0, array.Length);
        }

        [Fact]
        public void EmptyArrayHasOElements()
        {
            var array = new int[2];         // creating array (of size 2) - > each element has the default value of the type it's storing
            Assert.Equal(default, array[0]);
            Assert.Equal(0, array[1]);          // default(int) == 0
            Assert.Equal(2, array.Length);
        }

        [Fact]
        public void ThrowsExceptionWhenTryingToInsertElementToAmptyArray()
        {
            var array = new int[] { };
            Action invalidExecution = () => array[0] = 1;
            Assert.Throws<IndexOutOfRangeException>(invalidExecution);
        }
    }
}
