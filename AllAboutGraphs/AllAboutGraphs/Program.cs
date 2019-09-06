using DepthFirstSearch;
using ExtenstionsHelper;
using GraphDataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutGraphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(6);
            graph.AddEdge(0, 2);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 5);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 4);
            graph.AddEdge(3, 5);

            int startVertex = 0;
            DepthFirstPaths dfsPaths = new DepthFirstPaths(graph, startVertex);

            Console.WriteLine($"Path {startVertex} - 3? {dfsPaths.HasPathTo(3)} : {dfsPaths.PathTo(3).PrintStackLine()}");
            Console.WriteLine($"Path {startVertex} - 4? {dfsPaths.HasPathTo(4)} : {dfsPaths.PathTo(4).PrintStackLine()}");
            Console.WriteLine($"Path {startVertex} - 5? {dfsPaths.HasPathTo(5)} : {dfsPaths.PathTo(5).PrintStackLine()}");
        }
    }
}
