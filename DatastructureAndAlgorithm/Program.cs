using System;

namespace DatastructureAndAlgorithm
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Node firstNode = new Node { Value = 1 };
            Node secondNode = new Node { Value = 2 };

            Node thirdNode = new Node { Value = 3 };

            // Making node chain

            firstNode.Next = secondNode;
            secondNode.Next = thirdNode;

            // Printing in chain
            PrintChain(firstNode);
        }

        private static void PrintChain(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);

                node = node.Next;
            }
        }
    }
}