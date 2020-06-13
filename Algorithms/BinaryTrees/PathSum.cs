using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BinaryTrees
{
    public static class PathSum
    {
        public static bool HasPath(TreeNode currentNode, int sum)
        {
            if (currentNode == null)
                return false;

            var isLeaf = currentNode.Left == null && currentNode.Right == null;
            if (isLeaf && sum - currentNode.Value == 0)
                return true;

            sum -= currentNode.Value;
            return HasPath(currentNode.Left, sum) || HasPath(currentNode.Right, sum);
        }

        public static List<List<int>> GetPaths(TreeNode node, int sum)
        {
            var foundPaths = new List<List<int>>();
            FindPaths(node, sum, new List<int>(), foundPaths);
            return foundPaths;
        }


        private static void FindPaths(TreeNode currentNode, int sum, List<int> currentPath, List<List<int>> paths)
        {
            if (currentNode == null)
                return;

            currentPath.Add(currentNode.Value);

            var isLeaf = currentNode.Left == null && currentNode.Right == null;
            if (isLeaf && sum - currentNode.Value == 0)
                paths.Add(currentPath);
            
            sum -= currentNode.Value;
            FindPaths(currentNode.Left, sum, new List<int>(currentPath), paths);
            FindPaths(currentNode.Right, sum, new List<int>(currentPath), paths);
        }
    }
}
