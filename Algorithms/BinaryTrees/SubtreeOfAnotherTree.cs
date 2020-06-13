namespace Algorithms.BinaryTrees
{
    /// <summary>
    /// Time complexity O(n*m)
    /// Space complexity O(min(n,m))
    /// </summary>
    public static class SubtreeOfAnotherTree
    {
        public static bool IsSubtree(TreeNode tree, TreeNode subTree)
        {
            if (tree == null)
                return false;

            if (IsSameTree(tree, subTree))
                return true;

            return IsSubtree(tree.Left, subTree) || IsSubtree(tree.Right, subTree);
        }

        private static bool IsSameTree(TreeNode a, TreeNode b)
        {
            if (a == null || b == null)
                return a == null && b == null;
            if (a.Value != b.Value)
                return false;
            return IsSameTree(a.Left, b.Left) && IsSameTree(a.Right, b.Right);
        }
    }
}
