using Algorithms.Graphs;
using Algorithms.Miscellaneous;
using Xunit;

namespace csharp_playground.AlgorithmsTests
{
    public class MazeTest
    {
        [Fact]
        public void FindsExitPath()
        {
            var input = new char[,]
            {
                { 'S', 'X', 'X'},
                { ' ', ' ', ' '},
                { ' ', ' ', 'E'}
            };
            var hasExit = SearchMaze.HasExit(input);
            Assert.True(hasExit);
        }


        [Fact]
        public void ReturnsFalseIfPathNotFound()
        {
            var input = new char[,]
            {
                { 'S', 'X', 'X'},
                { ' ', ' ', 'X'},
                { ' ', 'X', 'E'}
            };
            var hasExit = SearchMaze.HasExit(input);
            Assert.False(hasExit);
        }
    }
}
