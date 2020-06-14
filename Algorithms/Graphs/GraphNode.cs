using System.Collections.Generic;

namespace Algorithms.Graphs
{
    public class GraphNode
    {
        public GraphNode(string value)
        {
            this.Value = value;
        }

        public string Value { get; set; }

        public List<GraphNode> Adjacent { get; set; }

        /*
         *      G------B
         *     /      / \
         *    /      A   \
         *   /      /|   C

         *  F-----E  |  /
         *  |      \ | /
         *  H------- D
         */
        public static GraphNode BuildGraphOne()
        {
            var A = new GraphNode("A");
            var B = new GraphNode("B");
            var C = new GraphNode("C");
            var D = new GraphNode("D");
            var E = new GraphNode("E");
            var F = new GraphNode("F");
            var G = new GraphNode("G");
            var H = new GraphNode("H");

            A.Adjacent = new List<GraphNode> { B, C, D, E};
            B.Adjacent = new List<GraphNode> { A, C, G };
            C.Adjacent = new List<GraphNode> { A, B, D};
            D.Adjacent = new List<GraphNode> { A,C,E,H };
            E.Adjacent = new List<GraphNode> { A,D,F};
            F.Adjacent = new List<GraphNode> { E,G,H };
            G.Adjacent = new List<GraphNode> { B,F };
            H.Adjacent = new List<GraphNode> { D, F};


            return A;
        }
    }
}
