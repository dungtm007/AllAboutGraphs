using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDataStructure
{
    public interface IGraph
    {
        void AddEdge(int v, int w);
        //int V(); // number of vertices
        int V { get; } // number of vertices
        int E { get; } // number of edges
        List<int> Adjacent(int v); // adjacent vertices
    }
}
