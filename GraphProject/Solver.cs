using System;
using System.Collections.Generic;
using System.Text;

namespace GraphProject
{
    class Solver<T>
    {
		class Meta
		{
            public enum VisitState {undiscovered, frontier, explored};
            public VisitState state;
            public Meta() { state = VisitState.undiscovered; }
		};

        public Graph<T> graph;

        private Meta[] metadata;
        private Stack<Graph<T>.Node> frontier;
        //private Queue<Graph<T>.Node> frontier;

		// Cleanup, setup and start our search.
        public void init(T start, Graph<T>.FindDelegate searcher)
        {
            metadata = new Meta[graph.nodes.Count];
            frontier = new Stack<Graph<T>.Node>();

            var snode = graph.FindNode(start, searcher);
            for(int i = 0; i < metadata.Length; ++i)
                metadata[i] = new Meta();

            metadata[snode.uid].state = Meta.VisitState.frontier;
            frontier.Push(snode);
        }

		public bool step()
        {
            var current = frontier.Pop();

            metadata[current.uid].state = Meta.VisitState.explored;

            Console.Write(current.uid + " ");
            
			foreach(var e in current.edges)
				if(metadata[e.end.uid].state == Meta.VisitState.undiscovered)
				{
		            frontier.Push(e.end);
	                metadata[e.end.uid].state = Meta.VisitState.frontier;
				}
            return frontier.Count != 0;
        }
	}
}
