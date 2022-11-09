using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
    internal class Graph_Traversal_BFS
    {
        /* 
        Following are the implementations of simple Breadth-First Traversal from a given source. 
        The implementation uses an adjacency list representation of graphs. 
        STL‘s list container stores lists of adjacent nodes and the queue of nodes needed for BFS traversal.
         */

        // Number of vertices.
        private int _vertics;

        // Adjacency Lists
        LinkedList<int>[] adjacent;

        public Graph_Traversal_BFS(int vertics)
        {
            adjacent = new LinkedList<int>[vertics];

            for (int i = 0; i < adjacent.Length; i++)
            {
                adjacent[i] = new LinkedList<int>();
            }
            _vertics = vertics;
        }

        // Function to add an edge into the graph
        public void AddEdge(int vertics, int edge)
        {
            adjacent[vertics].AddLast(edge);
        }

        // Prints BFS traversal from a given source.

        public void PrintBFS(int source)
        {
            // Mark all the vertices as not.
            // Visited(By defaukt set as false)
            bool[] visited = new bool[_vertics];

            for (int i = 0; i < _vertics; i++)
            {
                visited[i] = false;
            }

            // Create a queue for BFS
            LinkedList<int> queue = new LinkedList<int>();

            // Mark the current node as visited and enqueue it

            visited[source] = true;
            queue.AddLast(source);

            while (queue.Any())
            {
                // Dequeue a vertex from queue and print it.

                source = queue.First();

                Console.WriteLine(source + " ");

                queue.RemoveFirst();

                // Get all adjacent vertices of the dequeued vertex. 
                // If a adjacent has not been visited, then mark it visited and enqueue it.
            
                LinkedList<int> list = adjacent[source];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }
    }
}
