using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
