using Algorithms.BinaryTrees;
using Xunit;

namespace csharp_playground.Algorithms
{
    public class LowestCommonAncestorTest
    {
        [Fact]
        public void FindsALowerCommonAncestor()
        {
            var inputOne = TreeNode.BuildTreeOne();
            var lcaOne = LowestCommonAncestor.Get(inputOne, 1, 6);
            Assert.Equal(5, lcaOne.Value);

            var inputTwo = TreeNode.BuildTreeTwo();
            var lcaTwo = LowestCommonAncestor.Get(inputTwo, 5, 7);
            Assert.Equal(6, lcaTwo.Value);
        }

        [Fact]
        public void ReturnsLowestCommonAncestorForInherittedNodes()
        {
            var inputOne = TreeNode.BuildTreeOne();
            var lcaOne = LowestCommonAncestor.Get(inputOne, 7, 6);
            Assert.Equal(7, lcaOne.Value);

            var inputTwo = TreeNode.BuildTreeTwo();
            var lcaTwo = LowestCommonAncestor.Get(inputTwo, 5, 3);
            Assert.Equal(3, lcaTwo.Value);
        }
    }
}
