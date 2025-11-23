using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyMatrix
{
    internal class Graph
    {
        private int[,] matrix;
        private int vertices;
        public Graph(int vertices)
        {
            this.vertices = vertices;
            matrix=new int[vertices,vertices];
        }
        public void Add(int vertex1, int vertex2)
        {
            matrix[vertex1,vertex2] = 1;
            matrix[vertex2,vertex1] = 1;
        }
        public void PrintGraph()
        {
            Console.WriteLine("Adjacency Matrix:");
            for(int i = 0; i < vertices; i++)
            {
                for(int j = 0; j < vertices; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
