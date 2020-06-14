using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Graphs
{
    public static class BreadthFirstSearch
    {
        public static GraphNode ExampleGraph { get; set; } = GraphNode.BuildGraphOne();

        public static void Run(GraphNode start)
        {
            var queue= new Queue<GraphNode>();
            var processedNodes = new HashSet<GraphNode>();

            queue.Enqueue(start);

            while (queue.Any())
            {
                var current = queue.Dequeue();
                if (!processedNodes.Contains(current))
                {
                    processedNodes.Add(current);
                    ProcessNode(current);
                }

                foreach (var node in current.Adjacent)
                    if (!processedNodes.Contains(node))
                        queue.Enqueue(node);
            }
        }

        private static void ProcessNode(GraphNode node)
        {
            Console.Write($" {node.Value} ");
        }
    }
}
