using System.Collections.Generic;
using System.Linq;

namespace Algorithms.BinaryTrees
{
    /// <summary>
    /// In a binary tree find all nodes in the k-distance from the provided startNode.
    /// Distance is the number of vertices between any two nodes in the tree.
    /// Time complexity: O(n)
    /// Space complexity: O(n)
    /// n - number of nodes
    /// </summary>
    public static class NodesInKDistance
    {
        public static List<TreeNode> Find(TreeNode root, TreeNode startNode, int k)
        {
            var parents = new Dictionary<TreeNode, TreeNode>();
            DFS(root, parents);
            return BFS(startNode, k, parents);
        }

        /// <summary>
        /// BFS performs level by level search to find all nodes in k-level from the start node
        /// </summary>
        private static List<TreeNode> BFS(TreeNode startNode, int k, Dictionary<TreeNode, TreeNode> parents)
        {
            var currentLevel = 0;
            var seen = new HashSet<TreeNode>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(startNode);

            while (queue.Any())
            {
                if (currentLevel == k)
                    return queue.Where(x => x != null).ToList();

                var levelLength = queue.Count;
                for (int i = 0; i < levelLength; i++)
                {
                    var current = queue.Dequeue();
                    if (current == null)
                        continue;

                    if (!seen.Contains(current))
                        seen.Add(current);

                    if (!seen.Contains(current.Left))
                        queue.Enqueue(current.Left);
                    
                    if (!seen.Contains(current.Right))
                        queue.Enqueue(current.Right);

                    if (parents.ContainsKey(current) && !seen.Contains(parents[current]))
                        queue.Enqueue(parents[current]);
                }

                currentLevel++;
            }

            return new List<TreeNode>();
        }

        /// <summary>
        /// Creates a map from the node to the parent (to make it possible to traverse a tree in both directions)
        /// </summary>
        private static void DFS(TreeNode node, Dictionary<TreeNode, TreeNode> parents)
        {
            if (node == null)
                return;

            if (node.Left != null)
                parents.Add(node.Left, node);

            if (node.Right != null)
                parents.Add(node.Right, node);

            DFS(node.Left, parents);
            DFS(node.Right, parents);
        } 
    }
}
