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
            if (start == null)
                return;

            var queue = new Queue<GraphNode>();
            var processed = new HashSet<GraphNode>();

            queue.Enqueue(start);

            while (queue.Any())
            {
                var current = queue.Dequeue();
                if (processed.Contains(current))
                    continue;

                processed.Add(current);
                ProcessNode(current);

                foreach (var neighbour in current.Adjacent)
                    if (!processed.Contains(neighbour))
                        queue.Enqueue(neighbour);
            }
        }

        private static void ProcessNode(GraphNode node)
        {
            Console.Write($" {node.Value} ");
        }
    }
}
