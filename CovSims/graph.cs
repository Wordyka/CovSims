using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovSims
{
    internal class graph
    {
        int queryId = 0;
        char nodeSrc;
        char nodeDest;
        char node;
        double nodeValue;
        long valueOfNode;
        List<node> nodes;
        List<vertice> vertices;

        public graph()
        {
            nodes = new List<node>();
            vertices = new List<vertice>();
        }

        public graph(List<node> nodes, List<vertice> vertices)
        {
            this.nodes = nodes;
            this.vertices = vertices;
        }

        public int QueryId { get => queryId; set => queryId = value; }
        public long ValueOfNode { get => valueOfNode; set => valueOfNode = value; }
        public char Node { get => node; set => node = value; }
        public char NodeSrc { get => nodeSrc; set => nodeSrc = value; }
        public char NodeDest { get => nodeDest; set => nodeDest = value; }
        public double NodeValue { get => nodeValue; set => nodeValue = value; }
        internal List<node> Nodes { get => nodes; set => nodes = value; }
        internal List<vertice> Vertices { get => vertices; set => vertices = value; }
    }
}
