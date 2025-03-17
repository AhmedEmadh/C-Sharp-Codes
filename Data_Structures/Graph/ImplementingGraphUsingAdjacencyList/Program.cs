using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ImplementingGraphUsingAdjacencyList.Graph;

namespace ImplementingGraphUsingAdjacencyList
{
    public class Graph
    {
        public enum enGraphDirectionType { Directed, unDirected };
        enGraphDirectionType _GraphType;
        Dictionary<string,int> _VerticesDictionary;
        int _VerticesCount;
        Dictionary<string, List<Tuple<string,int>>> _AdjacencyList;
        public Graph(List<string> Vertices, enGraphDirectionType GraphType)
        {
            _GraphType = GraphType;
            _VerticesCount = Vertices.Count;
            _VerticesDictionary = new Dictionary<string, int>();
            _AdjacencyList = new Dictionary<string, List<Tuple<string, int>>>();
            for (int i = 0; i < _VerticesCount; i++)
            {
                _VerticesDictionary.Add(Vertices[i], i);
            }

        }
        public void AddEdge(string source, string destination, int weight)
        {
            if (!_VerticesDictionary.ContainsKey(source) || !_VerticesDictionary.ContainsKey(destination))
            {
                throw new Exception("Source or Destination Vertex not found");
            }
            if (_AdjacencyList.ContainsKey(source))
            {
                _AdjacencyList[source].Add(new Tuple<string, int>(destination, weight));
            }
            else
            {
                _AdjacencyList.Add(source, new List<Tuple<string, int>> { new Tuple<string, int>(destination, weight) });
            }
            if (_GraphType == enGraphDirectionType.unDirected)
            {
                if (_AdjacencyList.ContainsKey(destination))
                {
                    _AdjacencyList[destination].Add(new Tuple<string, int>(source, weight));
                }
                else
                {
                    _AdjacencyList.Add(destination, new List<Tuple<string, int>> { new Tuple<string, int>(source, weight) });
                }
            }
        }
        public void RemoveEdge(string source, string destination)
        {
            if (!_VerticesDictionary.ContainsKey(source) || !_VerticesDictionary.ContainsKey(destination))
            {
                throw new Exception("Source or Destination Vertex not found");
            }
            if (_AdjacencyList.ContainsKey(source))
            {
                _AdjacencyList[source].RemoveAll(x => x.Item1 == destination);
            }
            if (_GraphType == enGraphDirectionType.unDirected)
            {
                if (_AdjacencyList.ContainsKey(destination))
                {
                    _AdjacencyList[destination].RemoveAll(x => x.Item1 == source);
                }
            }
        }
        public void DisplayGraph(string Message)
        {
            Console.WriteLine(Message);
            foreach (var item in _AdjacencyList)
            {
                Console.Write(item.Key + " -> ");
                foreach (var edge in item.Value)
                {
                    Console.Write(edge.Item1 + "(" + edge.Item2 + ") ");
                }
                Console.WriteLine();
            }
        }
        public bool IsEdge(string source, string destination)
        {
            if (_AdjacencyList.ContainsKey(source))
            {
                return _AdjacencyList[source].Any(x => x.Item1 == destination);
            }
            return false;
        }
        public int GetInDegree(string vertex)
        {
            int inDegree = 0;
            foreach (var item in _AdjacencyList)
            {
                inDegree += item.Value.Count(x => x.Item1 == vertex);
            }
            return inDegree;
        }
        public int GetOutDegree(string vertex)
        {
            if (_AdjacencyList.ContainsKey(vertex))
            {
                return _AdjacencyList[vertex].Count;
            }
            return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of vertices with string labels
            List<string> vertices = new List<string> { "A", "B", "C", "D", "E" };

            // Example 1 in Slides: Undirected Graph
            Graph graph1 = new Graph(vertices, enGraphDirectionType.unDirected);

            // Add some edges with default weights=1 between vertices
            graph1.AddEdge("A", "B", 1);
            graph1.AddEdge("A", "C", 1);
            graph1.AddEdge("B", "D", 1);
            graph1.AddEdge("C", "D", 1);
            graph1.AddEdge("B", "E", 1);
            graph1.AddEdge("D", "E", 1);

            // Display the adjacency list to visualize the graph
            graph1.DisplayGraph("Adjacency List for Example1 (Undirected Graph):");

            Console.WriteLine("\n------------------------------\n");

            // Example 2 in Slides: Directed Graph
            Graph graph2 = new Graph(vertices, enGraphDirectionType.Directed);

            // Add some edges with weights between vertices
            graph2.AddEdge("A", "A", 1);
            graph2.AddEdge("A", "B", 1);
            graph2.AddEdge("A", "C", 1);
            graph2.AddEdge("B", "E", 1);
            graph2.AddEdge("D", "B", 1);
            graph2.AddEdge("D", "C", 1);
            graph2.AddEdge("D", "E", 1);

            // Display the adjacency list to visualize the graph
            graph2.DisplayGraph("Adjacency List for Example2 (Directed Graph):");

            // Get and display the indegree and outdegree of vertex 'D'
            Console.WriteLine("\nInDegree of vertex D: " + graph2.GetInDegree("D"));
            Console.WriteLine("\nOutDegree of vertex D: " + graph2.GetOutDegree("D"));

            Console.WriteLine("\n------------------------------\n");

            // Example 3 in Slides: Weighted Graph
            Graph graph3 = new Graph(vertices, enGraphDirectionType.unDirected);

            // Add some edges with weights between vertices
            graph3.AddEdge("A", "B", 5);
            graph3.AddEdge("A", "C", 3);
            graph3.AddEdge("B", "D", 12);
            graph3.AddEdge("C", "D", 10);
            graph3.AddEdge("B", "E", 2);
            graph3.AddEdge("D", "E", 7);

            // Display the adjacency list to visualize the graph
            graph3.DisplayGraph("Adjacency List for Example3 (Weighted Graph):");

            // Check if there is an edge between 'A' and 'B' and display the result
            Console.WriteLine("\nIs there an edge between A and B in Graph3? " + graph3.IsEdge("A", "B"));

            // Remove the edge between 'E' and 'D'
            graph3.RemoveEdge("E", "D");

            // Display the updated adjacency list after removing the edge
            graph3.DisplayGraph("After Removing Edge between E and D:");

            Console.ReadKey();

        }
    }
}
