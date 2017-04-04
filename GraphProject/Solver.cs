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

		public bool step()
        {
            // Pop data off the frontier.
            var current = frontier.Pop();
            // update the metadata for the node that was popped.

            // Print the id of the node.
            Console.Write(current.uid);
            
            // add all of the 'undiscovered' neighbors of that node onto the stack.
            // update their metadata to 'frontier' status.


            return frontier.Count != 0;
        }
	}
}
