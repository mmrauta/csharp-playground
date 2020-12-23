using Algorithms.BinaryTrees;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace csharp_playground.AlgorithmsTests
{
    public class NodesInKDistanceTest
    {
        [Fact]
        public void FindKDistantNodes()
        {
            var inputOne = TreeNode.BuildTreeOne();
            var nodes = NodesInKDistance.Find(inputOne, inputOne.Left, 1);
            var nodesValues = nodes.Select(x => x.Value).ToList();
            Assert.Equal(new List<int> { 1, 5 }, nodesValues);

            var inputTwo = TreeNode.BuildTreeTwo();
            var nodesTwo = NodesInKDistance.Find(inputTwo, inputTwo.Left, 3);
            var nodesValuesTwo = nodesTwo.Select(x => x.Value).ToList();
            Assert.Equal(new List<int> { 5, 7 }, nodesValuesTwo);

            var inputThree = TreeNode.BuildTreeThree();
            var nodesThree = NodesInKDistance.Find(inputThree, inputThree.Left.Left, 4);
            var nodesValuesThree = nodesThree.Select(x => x.Value).ToList();
            Assert.Equal(new List<int> { 0, 8 }, nodesValuesThree);
        }
    }
}