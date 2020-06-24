using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Graphs
{
    public static class DepthFirstSearch
    {
        public static void Run(GraphNode start)
        {
            var stack = new Stack<GraphNode>();
            var processedNodes = new HashSet<GraphNode>();

            stack.Push(start);

            while (stack.Any())
            {
                var current = stack.Pop();
                if (!processedNodes.Contains(current))
                {
                    processedNodes.Add(current);
                    ProcessNode(current);
                }

                foreach (var node in current.Adjacent)
                    if (!processedNodes.Contains(node))
                        stack.Push(node);
            }
        }

        private static void ProcessNode(GraphNode node)
        {
            Console.Write($" {node.Value} ");
        }
    }
}
