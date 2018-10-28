using Xunit;

namespace csharp_playground
{
    public class CharsAndStringsTest
    {
        [Fact]
        public void GetIntFromChar()
        {
            var letterInAsci = (int)'m';
            Assert.Equal(109, letterInAsci);
        }

        [Fact]
        public void GetStringFromChar()
        {
            var letterAsText = 'm'.ToString();
            Assert.Equal("m", letterAsText);
        }

        [Fact]
        public void CheckIfStringContainsSomeChars()
        {
            var text = "my dog";

            var containsTheWord = text.Contains("dog");
            var containsTheChar = text.Contains("d");

            Assert.True(containsTheWord);
            Assert.True(containsTheChar);
        }

        [Fact]
        public void CheckExistanceAndPositionOfSomeChars()
        {
            var text = "my dog";

            var charIndex = text.IndexOf("o");
            var wordIndex = text.IndexOf("dog");
            var firstMatchingLetterIndex = text.IndexOfAny(new[] {'g', 'a', 'b', 'c', 'y'});

            var containsTheWord = charIndex > -1;
            var containsTheChar = wordIndex > -1;
            var containsAnyOfTheLetters = firstMatchingLetterIndex > -1;

            Assert.Equal(4, charIndex);
            Assert.Equal(3, wordIndex);
            Assert.Equal(1, firstMatchingLetterIndex);

            Assert.True(containsTheWord);
            Assert.True(containsTheChar);
            Assert.True(containsAnyOfTheLetters);
        }
    }
}
