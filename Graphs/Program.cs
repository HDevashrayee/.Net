using System;

namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph_Traversal_BFS graph_Traversal_BFS = new Graph_Traversal_BFS(4);
            graph_Traversal_BFS.AddEdge(0, 1);
            graph_Traversal_BFS.AddEdge(0, 2);
            graph_Traversal_BFS.AddEdge(1, 2);
            graph_Traversal_BFS.AddEdge(2, 0);
            graph_Traversal_BFS.AddEdge(2, 3);
            graph_Traversal_BFS.AddEdge(3, 3);

            Console.Write("Following is Breadth First " +
                  "Traversal(starting from " +
                  "vertex 2)\n");

            graph_Traversal_BFS.PrintBFS(2);
        }
    }
}
