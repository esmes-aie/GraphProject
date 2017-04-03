using System;
using System.Collections.Generic;
using System.Text;

namespace GraphProject
{
    public class Graph<T>
    {
        public class Node
        {            
            public Node(T a_data, uint a_id)
            {
                data  = a_data;
                edges = new List<Edge>();
                uid = a_id;
            }

            public uint uid         { private set; get; }
            public T data           { private set; get; }
            public List<Edge> edges { private set; get; }
        }

        public class Edge
        {
            public Edge(Node a_start, Node a_end, float a_weight = 1)
            {
                start   = a_start;
                end     = a_end;
                weight  = a_weight;
            }
            public Node start   { private set; get; }
            public Node end     { private set; get; }
            public float weight { private set; get; }
        }

        public List<Node> nodes { private set; get; }
        public List<Edge> edges { private set; get; }
        uint id_counter;

        public Graph()
        {
            nodes = new List<Node>();
            edges = new List<Edge>();
            id_counter = 0;
        }

        public Node AddNode(T a_data)
        {
            // TODO: Try and ensure there are no duplicate references.
            Node n = new Node(a_data, id_counter);
            id_counter++;
            nodes.Add(n);
            return n;
        }

        public Edge AddEdge(Node a_start, Node a_end, float a_weight = 1, bool undirected = true)
        {
            if (!nodes.Contains(a_start) || !nodes.Contains(a_end))
                return null;
                
            Edge a = new Edge(a_start, a_end, a_weight);
            a_start.edges.Add(a);
            edges.Add(a);

            if(undirected)
            { 
                Edge b = new Edge(a_end, a_start, a_weight);
                a_end.edges.Add(b);
                edges.Add(b);
            }
            return a;
        }

        // add nodes and edges
        // Find nodes according to value
    }
}
