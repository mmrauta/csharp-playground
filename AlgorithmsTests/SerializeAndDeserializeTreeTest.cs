using Algorithms.BinaryTrees;
using Xunit;

namespace csharp_playground.AlgorithmsTests
{
    public class SerializeAndDeserializeTreeTest
    {
        [Fact]
        public void Serializes()
        {
            var inputOne = TreeNode.BuildTreeOne();
            var resultOne = SerializeAndDeserializeBinaryTree.Serialize(inputOne);
            Assert.Equal("531XXX76XXX", resultOne);

            var inputTwo = TreeNode.BuildTreeTwo();
            var resultTwo = SerializeAndDeserializeBinaryTree.Serialize(inputTwo);
            Assert.Equal("31XX65XX7XX", resultTwo);
        }

        [Fact]
        public void Deserializes()
        {
            var deserializedOne = SerializeAndDeserializeBinaryTree.Deserialize("531XXX76XXX");
            var resultOne = SerializeAndDeserializeBinaryTree.Serialize(deserializedOne);
            Assert.Equal("531XXX76XXX", resultOne);

            var deserializedTwo =  SerializeAndDeserializeBinaryTree.Deserialize("31XX65XX7XX");
            var resultTwo = SerializeAndDeserializeBinaryTree.Serialize(deserializedTwo);
            Assert.Equal("31XX65XX7XX", resultTwo);
        }
    }
}
