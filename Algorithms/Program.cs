using System;
using Algorithms.BinaryTrees;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DFS Binary Tree");

            Console.WriteLine();
            Console.WriteLine("Preorder");
            DepthFirstSearch.PreorderTraversal(DepthFirstSearch.TreeOne);
            Console.WriteLine();
            DepthFirstSearch.PreorderTraversal(DepthFirstSearch.TreeTwo);

            Console.WriteLine();
            Console.WriteLine("Inorder");
            DepthFirstSearch.InorderTraversal(DepthFirstSearch.TreeOne);
            Console.WriteLine();
            DepthFirstSearch.InorderTraversal(DepthFirstSearch.TreeTwo);

            Console.WriteLine();
            Console.WriteLine("Postorder");
            DepthFirstSearch.PostorderTraversal(DepthFirstSearch.TreeOne);
            Console.WriteLine();
            DepthFirstSearch.PostorderTraversal(DepthFirstSearch.TreeTwo);

            Console.WriteLine();
            Console.WriteLine("DFS Graph");
            Console.WriteLine();
            Graphs.DepthFirstSearch.Run(Graphs.DepthFirstSearch.ExampleGraph);

            Console.WriteLine();
            Console.WriteLine("BFS Graph");
            Console.WriteLine();
            Graphs.BreadthFirstSearch.Run(Graphs.BreadthFirstSearch.ExampleGraph);

        }
    }
}
