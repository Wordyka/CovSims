using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovSims
{
    internal class vertice
    {
        private char node;
        private int nodeValue;

        public vertice()
        {

        }

        public vertice(char node, int nodeValue)
        {
            this.node = node;
            this.nodeValue = nodeValue;
        }

        public char Node { get => node; set => node = value; }
        public int NodeValue { get => nodeValue; set => nodeValue = value; }
    }
}
