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

        Node AddNode(T a_data)
        {
            // TODO: Try and ensure there are no duplicate references.
            Node n = new Node(a_data, id_counter);
            id_counter++;
            nodes.Add(n);
            return n;
        }


        // add nodes and edges
        // Find nodes according to value
    }
}
