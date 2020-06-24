using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.BinaryTrees
{
    /// <summary>
    /// n - number of nodes; h - height of a tree
    /// Time Complexity: O(n)
    /// Space Complexity: O(h); Worst: O(n); Average: O(logn)
    /// </summary>
    public static class BreadthFirstSearch
    {
        public static void Traversal(TreeNode node)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            while (queue.Any())
            {
                var current = queue.Dequeue();
                if (current == null)
                    continue;

                ProcessCurrentNode(current);

                queue.Enqueue(current.Left);
                queue.Enqueue(current.Right);
            }
        }

        private static void ProcessCurrentNode(TreeNode node)
        {
            Console.Write(node.Value);
        }
    }
}
