using GraphDataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthFirstSearch
{
    public class DepthFirstPaths
    {
        private bool[] marked;
        private int[] edgeTo;
        private int s; // source/start vertex

        public DepthFirstPaths(Graph G, int s)
        {
            this.s = s;
            marked = new bool[G.V];
            edgeTo = new int[G.V];
            DFS(G, s);
        }

        private void DFS(Graph G, int v)
        {
            marked[v] = true;
            foreach (var w in G.Adjacent(v))
            {
                if (!marked[w])
                {    
                    edgeTo[w] = v;
                    DFS(G, w);
                }
            }
        }

        public bool HasPathTo(int v)
        {
            return marked[v];
        }

        public Stack<int> PathTo(int v)
        {
            if (!HasPathTo(v))
            {
                return null;
            }
            Stack<int> path = new Stack<int>();
            for (int x = v; x != s; x = edgeTo[x])
            {
                path.Push(x);
            }
            path.Push(s);
            return path;
        }

    }
}
