using System.Collections.Generic;
using Algorithms.BinaryTrees;
using Xunit;

namespace csharp_playground.AlgorithmsTests
{
    public class PathSumTest
    {
        [Fact]
        public void FindsALowerCommonAncestor()
        {
            var inputOne = TreeNode.BuildTreeOne();
            var hasSumOne = PathSum.HasPath(inputOne, 9);
            Assert.True(hasSumOne);

            var inputTwo = TreeNode.BuildTreeThree();
            var hasSumTwo = PathSum.HasPath(inputTwo, 4);
            Assert.True(hasSumTwo);
        }

        [Fact]
        public void ReturnsLowestCommonAncestorForInheritedNodes()
        {
            var inputOne = TreeNode.BuildTreeOne();
            var hasSumOne = PathSum.HasPath(inputOne, 8);
            Assert.False(hasSumOne);

            var inputTwo = TreeNode.BuildTreeThree();
            var hasSumTwo = PathSum.HasPath(inputTwo, 18);
            Assert.False(hasSumTwo);
        }

        [Fact]
        public void FindsPaths()
        {
            var inputOne = TreeNode.BuildTreeOne();
            var pathsOne = PathSum.GetPaths(inputOne, 9);
            Assert.Equal(new List<List<int>> {new List<int>{5,3,1}}, pathsOne);

            var inputTwo = TreeNode.BuildTreeThree();
            var pathsTwo = PathSum.GetPaths(inputTwo, 17);
            Assert.Equal(new List<List<int>> { new List<int> { 3,5,2,7} }, pathsTwo);

            var inputThree = TreeNode.BuildTreeFour();
            var pathsThree = PathSum.GetPaths(inputThree, 14);
            var multiplePaths = new List<List<int>> {new List<int> { 3, 5, 6}, new List<int> {3, 5, 2, 4}, new List<int> {3, 1, 8, 2}};
            Assert.Equal(multiplePaths, pathsThree);
        }

        [Fact]
        public void DoesNotFindNotExistingPaths()
        {
            var inputOne = TreeNode.BuildTreeTwo();
            var pathsOne = PathSum.GetPaths(inputOne, 9);
            Assert.Empty(pathsOne);

            var inputTwo = TreeNode.BuildTreeThree();
            var pathsTwo = PathSum.GetPaths(inputTwo, 9);
            Assert.Empty(pathsTwo);
        }
    }
}
