using Algorithms.BinaryTrees;
using Xunit;

namespace csharp_playground.Algorithms
{
    public class SubtreeOfAnotherTreeTest
    {
        [Fact]
        public void FindsSubtree()
        {
            var inputOne = TreeNode.BuildTreeThree();
            var inputTwo = TreeNode.BuildTreeThreeSubtree();

            var isSubtree = SubtreeOfAnotherTree.IsSubtree(inputOne, inputTwo);
            Assert.True(isSubtree);
        }

        [Fact]
        public void DoersNotFindSubtrees()
        {
            var inputOne = TreeNode.BuildTreeThree();
            var inputTwo = TreeNode.BuildTreeThreeFakeSubtree();

            var isSubtree = SubtreeOfAnotherTree.IsSubtree(inputOne, inputTwo);
            Assert.False(isSubtree);
        }
    }
}
