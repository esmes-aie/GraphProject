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

            for (int i = 0; i < 6; ++i)
                graph.AddNode(i);

            graph.AddEdge(0, 1, diff, 0.0001f, 1, false);
            graph.AddEdge(1, 2, diff, 0.0001f, 1, false);
            graph.AddEdge(2, 3, diff, 0.0001f, 1, false);
            graph.AddEdge(3, 4, diff, 0.0001f, 1, false);

            graph.AddEdge(3, 5, diff, 0.0001f, 1, false);
            graph.AddEdge(2, 0, diff, 0.0001f, 1, false);
            graph.AddEdge(0, 5, diff, 0.0001f, 1, false);
            graph.AddEdge(5, 4, diff, 0.0001f, 1, false);

            Solver<int> solver = new Solver<int>();
            solver.graph = graph;
            solver.init(0, 4, diff);

            Console.WriteLine("Starting the Search:");
            while (solver.step());

            
            Console.WriteLine("\nPress enter to close.");
            Console.ReadLine();

            var finalPath = solver.solution;
        }
    }
}