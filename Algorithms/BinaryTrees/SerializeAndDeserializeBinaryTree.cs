using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.BinaryTrees
{
    public static class SerializeAndDeserializeBinaryTree
    {
        public static string Serialize(TreeNode node)
        {
            if (node == null)
                return string.Empty;

            var result = new StringBuilder();
            Serialize(node, result);

            return result.ToString();
        }

        private static void Serialize(TreeNode node, StringBuilder builder)
        {
            if (node == null)
            {
                builder.Append("X");
                return;
            }

            builder.Append(node.Value);

            Serialize(node.Left, builder);
            Serialize(node.Right, builder);
        }


        public static TreeNode Deserialize(string input)
        {
            if (string.IsNullOrEmpty(input) || input[0] == 'X')
                return null;

            var nodeValues = new Queue<char>(input);
            var result = Deserialize(nodeValues);
            return result;
        }

        private static TreeNode Deserialize(Queue<char> nodeValues)
        {
            var nodeValue = nodeValues.Dequeue();
            if (nodeValue == 'X')
                return null;

            var currentNode = new TreeNode(GetValue(nodeValue));

            currentNode.Left = Deserialize(nodeValues);
            currentNode.Right = Deserialize(nodeValues);

            return currentNode;
        }

        private static int GetValue(char digit)
        {
            return int.Parse(digit.ToString());
        }
    }
}
