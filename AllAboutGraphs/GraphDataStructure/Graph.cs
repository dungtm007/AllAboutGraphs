using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDataStructure
{
    public class Graph : IGraph
    {
        public int V { get; }

        public int E { get; private set; }

        private List<int>[] adjacentList;
        
        public Graph(int V)
        {
            this.V = V;
            adjacentList = new List<int>[V];
            for(int v = 0; v < V; v++)
            {
                adjacentList[v] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adjacentList[v].Add(w);
            adjacentList[w].Add(v);
            E++;
        }

        public List<int> Adjacent(int v)
        {
            return adjacentList[v];
        }
    }
}
