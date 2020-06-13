namespace Algorithms.BinaryTrees
{
    /// <summary>
    /// n - number of nodes; h - height of the tree
    /// Time complexity: O(n)
    /// Space complexity: O(h)
    /// </summary>
    public static class LowestCommonAncestor
    {
        /// <summary>
        /// Gets the lowest common ancestor node in a binary tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="x">first value of a tree node (must exist and be unique in the tree)</param>
        /// <param name="y">second value of a tree node (must exist and be unique in the tree)</param>
        /// <returns>LCA node or null if LCA was not found.</returns>
        public static TreeNode Get(TreeNode root, int x, int y)
        {
            if (root == null)
                return null;

            if (root.Value == x || root.Value == y)
                return root;

            var leftSearchResult = Get(root.Left, x, y);
            var rightSearchResult = Get(root.Right, x, y);

            if (leftSearchResult == null)
            {
                return rightSearchResult;
            }

            if (rightSearchResult == null)
            {
                return leftSearchResult;
            }

            return root;
        }
    }
}
