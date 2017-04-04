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

        // represent 1 loop of the search
			// pop a node from the stack
			// print the node's ID to the screen
			// Set the node's metadata to explored
			// Add all of the node's undiscovered neighbors to the stack
		public bool step()
        {
            Console.Write(frontier.Peek().uid);
            return false;
        }
	}
}
