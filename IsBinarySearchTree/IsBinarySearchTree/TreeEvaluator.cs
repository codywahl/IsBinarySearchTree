using System;

namespace IsBinarySearchTree
{
    public class TreeEvaluator
    {
        private static void Main(string[] args)
        {
            var node1 = new Node() { Data = 5 };
            var node2 = new Node() { Data = 4 };
            var node3 = new Node() { Data = 6 };

            node1.LeftNode = node2;
            node1.RightNode = node3;

            Console.WriteLine("Is a BST? : " + IsBinarySearchTree(node1, int.MinValue, int.MaxValue));

            node2.Data = 6;

            Console.WriteLine("Is a BST? : " + IsBinarySearchTree(node1, int.MinValue, int.MaxValue));

            Console.ReadKey();
        }

        private static bool IsBinarySearchTree(Node node, int min, int max)
        {
            if (node == null)
                return true;

            if (node.Data < min || node.Data > max)
                return false;

            return IsBinarySearchTree(node.LeftNode, min, node.Data - 1) && IsBinarySearchTree(node.RightNode, node.Data + 1, max);
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }

        public Node()
        {
        }

        public Node(int data, Node leftNode, Node rightNode)
        {
            Data = data;
            LeftNode = leftNode;
            RightNode = rightNode;
        }
    }
}