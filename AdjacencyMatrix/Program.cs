using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(5);
            g.Add(0, 1);
            g.Add(0, 4);
            g.Add(1, 2);
            g.Add(1, 4);
            g.Add(2, 3);
            g.Add(2, 4);
            g.Add(3, 4);
            g.PrintGraph();
          }
    }
}
