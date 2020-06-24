using System;

namespace Algorithms.BinaryTrees
{
    /// <summary>
    /// n - number of nodes; h - height of a tree
    /// Time Complexity: O(n)
    /// Space Complexity: O(h); Worst: O(n); Average: O(logn)
    /// </summary>
    public static class DepthFirstSearch
    {
        public static void PreorderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            ProcessCurrentNode(node);
            PreorderTraversal(node.Left);
            PreorderTraversal(node.Right);
        }

        /// <summary>
        /// Inorder traversal of a binary SEARCH tree returns sorted elements
        /// </summary>
        public static void InorderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            InorderTraversal(node.Left);
            ProcessCurrentNode(node);
            InorderTraversal(node.Right);
        }

        public static void PostorderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            PostorderTraversal(node.Left);
            PostorderTraversal(node.Right);
            ProcessCurrentNode(node);
        }

        private static void ProcessCurrentNode(TreeNode node)
        {
            Console.Write(node.Value);
        }
    }
}
