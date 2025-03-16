using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphRepresentationAndConversionExample
{
    internal class Program
    {
        enum enVertix { A = 0, B = 1, C = 2, D = 3, E = 4 };
        static void Main(string[] args)
        {

            //Vertices: A, B, C, D, E => 5
            /*
             Edges:
                A → B
                A → C
                B → D
                C → D
                D → E
            Questions:
                1.Create an adjacency matrix to represent the graph.
                2.Create an adjacency list to represent the same graph.
             */
            bool[,] AdjacencyMatrix = new bool[5, 5];
            // A → B
            AdjacencyMatrix[(int)enVertix.A, (int)enVertix.B] = true;
            // A → C
            AdjacencyMatrix[(int)enVertix.A, (int)enVertix.C] = true;
            // B → D
            AdjacencyMatrix[(int)enVertix.B, (int)enVertix.D] = true;
            // C → D
            AdjacencyMatrix[(int)enVertix.C, (int)enVertix.D] = true;
            // D → E
            AdjacencyMatrix[(int)enVertix.D, (int)enVertix.E] = true;
            // Adjacency List
            enVertix[][] AdjacencyList = new enVertix[5][];

            AdjacencyList[(int)enVertix.A] = new enVertix[] { enVertix.B,enVertix.C};
            AdjacencyList[(int)enVertix.B] = new enVertix[] { enVertix.D};
            AdjacencyList[(int)enVertix.C] = new enVertix[] { enVertix.D};
            AdjacencyList[(int)enVertix.D] = new enVertix[] { enVertix.E};
            AdjacencyList[(int)enVertix.E] = new enVertix[] { };

            // Print Adjacency Matrix
            Console.WriteLine("Adjacency Matrix");
            PrintAdjacencyMatrix(AdjacencyMatrix);
            Console.WriteLine();
            // Print Adjacency List
            Console.WriteLine("Adjacency List");
            PrintAdjacencyList(AdjacencyList);
            Console.WriteLine();
            Console.ReadKey();

        }
        static void PrintAdjacencyMatrix(bool[,] adjacencyMatrix)
        {
            Console.Write("  | ");
            for (int i = 0; i < adjacencyMatrix.GetLength(1); i++)
            {
                Console.Write((enVertix)i + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                Console.Write((enVertix)i + " | ");
                for (int j = 0; j < adjacencyMatrix.GetLength(1); j++)
                {
                    Console.Write(adjacencyMatrix[i, j] ? "1 " : "0 ");
                }
                Console.WriteLine();
            }
        }
        static void PrintAdjacencyList(enVertix[][] adjacencyList)
        {
            for (int i = 0; i < adjacencyList.Length; i++)
            {
                Console.Write((enVertix)i + " -> ");
                for (int j = 0; j < adjacencyList[i].Length; j++)
                {
                    Console.Write(adjacencyList[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}