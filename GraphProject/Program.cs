using System;
using System.Collections.Generic;
using System.Text;

namespace GraphProject
{
    class Program
    {
        static float diff(int a, int b)
        {
            return Math.Abs(a - b);
        }

        static void Main(string[] args)
        {
            Graph<int> graph = new Graph<int>();

            for (int i = 0; i < 16; ++i)
                graph.AddNode(i);

            graph.AddEdge(12, 13, diff);
        }
    }
}