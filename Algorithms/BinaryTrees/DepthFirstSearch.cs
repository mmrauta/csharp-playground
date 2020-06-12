using System;

namespace Algorithms.BinaryTrees
{
    /// <summary>
    /// n - number of nodes; h - height of a tree
    /// Time Complexity: O(n)
    /// Space Complexity: O(h); Worst: O(n); Average: O(log{2}n)
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
        /// Inorder traversal of a binary search tree returns sorted elements
        /// </summary>
        /// <param name="node"></param>
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

        public static TreeNode TreeOne { get; set; } = BuildTreeOne();

        public static TreeNode TreeTwo { get; set; } = BuildTreeTwo();

        /*
         *      5
         *     / \
         *    3   7
         *   /   /
         *  1   6
         */
        public static TreeNode BuildTreeOne()
        {
            var treeOne = new TreeNode(5)
            {
                Left = new TreeNode(3),
                Right = new TreeNode(7)
            };

            treeOne.Left.Left = new TreeNode(1);
            treeOne.Right.Left = new TreeNode(6);

            return treeOne;
        }

        /*
         *      3
         *     / \
         *    1   6
         *       / \
         *      5   7
         */
        public static TreeNode BuildTreeTwo()
        {
            var treeTwo = new TreeNode(3)
            {
                Left = new TreeNode(1),
                Right = new TreeNode(6)
            };

            treeTwo.Right.Left = new TreeNode(5);
            treeTwo.Right.Right = new TreeNode(7);

            return treeTwo;
        }
    }
}
