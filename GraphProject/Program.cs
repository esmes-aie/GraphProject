using System;
using System.Collections.Generic;
using System.Text;

namespace GraphProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<int> graph = new Graph<int>();

            for (int i = 0; i < 16; ++i)
                graph.AddNode(i);

        }
    }
}