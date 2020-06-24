using Algorithms.BinaryTrees;
using Algorithms.Graphs;
using System;

namespace Algorithms
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DFS Binary Tree");

            Console.WriteLine();
            Console.WriteLine("Preorder");
            BinaryTrees.DepthFirstSearch.PreorderTraversal(TreeNode.BuildTreeOne());
            Console.WriteLine();
            BinaryTrees.DepthFirstSearch.PreorderTraversal(TreeNode.BuildTreeTwo());

            Console.WriteLine();
            Console.WriteLine("Inorder");
            BinaryTrees.DepthFirstSearch.InorderTraversal(TreeNode.BuildTreeOne());
            Console.WriteLine();
            BinaryTrees.DepthFirstSearch.InorderTraversal(TreeNode.BuildTreeTwo());

            Console.WriteLine();
            Console.WriteLine("Postorder");
            BinaryTrees.DepthFirstSearch.PostorderTraversal(TreeNode.BuildTreeOne());
            Console.WriteLine();
            BinaryTrees.DepthFirstSearch.PostorderTraversal(TreeNode.BuildTreeTwo());

            Console.WriteLine();
            Console.WriteLine("BFS Binary Tree");
            BinaryTrees.BreadthFirstSearch.Traversal(TreeNode.BuildTreeTwo());

            Console.WriteLine();
            Console.WriteLine("DFS Graph");
            Console.WriteLine();
            Graphs.DepthFirstSearch.Run(GraphNode.BuildGraphOne());

            Console.WriteLine();
            Console.WriteLine("BFS Graph");
            Console.WriteLine();
            Graphs.BreadthFirstSearch.Run(Graphs.BreadthFirstSearch.ExampleGraph);

        }
    }
}
