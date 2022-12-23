using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovSims
{
    internal class node
    {
        private int source;
        private int destination;
        private int value;

        public node()
        {

        }

        public node(int source, int destination, int value)
        {
            this.source = source;
            this.destination = destination;
            this.value = value;
        }

        public int Source { get => source; set => source = value; }
        public int Destination { get => destination; set => destination = value; }
        public int Value { get => value; set => this.value = value; }
    }
}
