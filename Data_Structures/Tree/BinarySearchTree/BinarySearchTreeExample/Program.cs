
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BinarySearchTreeExample
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
        // Constructor initializing the node with a value
        public BinaryTreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; private set; }
        public BinaryTree()
        {
            Root = null;
        }
        public void Insert(T value)
        {
            BinaryTreeNode<T> newNode = new BinaryTreeNode<T>(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);
            while (queue.Count > 0)
            {
                BinaryTreeNode<T> node = queue.Dequeue();
                if (node.Left == null)
                {
                    node.Left = newNode;
                    return;
                }
                else
                {
                    queue.Enqueue(node.Left);
                }
                if (node.Right == null)
                {
                    node.Right = newNode;
                    return;
                }
                else
                {
                    queue.Enqueue(node.Right);
                }
            }
        }
        public void PrintTree()
        {
            PrintTree(Root, 0);
        }
        private void PrintTree(BinaryTreeNode<T> node, int level)
        {
            if (node == null)
            {
                return;
            }
            PrintTree(node.Right, level + 1);
            if (level != 0)
            {
                for (int i = 0; i < level - 1; i++)
                {
                    Console.Write("|\t");
                }
                Console.WriteLine("|-------" + node.Value);
            }
            else
            {
                Console.WriteLine(node.Value);
            }
            PrintTree(node.Left, level + 1);
            
        }
        public void PreOrderTraversal()
        {
            PreOrderTraversal(Root);
            Console.WriteLine();
        }
        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
            Console.WriteLine();
        }
        public void InOrderTraversal()
        {
            InOrderTraversal(Root);
            Console.WriteLine();
        }
        private static void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            /*
              PreOrder Traversal visits the current node before its child nodes. 
              The process for PreOrder Traversal is as follows:


                 - Visit the current node.
                 - Recursively perform PreOrder Traversal of the left subtree.
                 - Recursively perform PreOrder Traversal of the right subtree.
            */


            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }
        private void PostOrderTraversal(BinaryTreeNode<T> node)
        {

            /*
              PostOrder Traversal visits the current node after its child nodes. 
              The process for PostOrder Traversal is:


                - Recursively perform PostOrder Traversal of the left subtree.
                - Recursively perform PostOrder Traversal of the right subtree.
                - Visit the current node.
           */


            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.Write(node.Value + " ");
            }
        }
        private void InOrderTraversal(BinaryTreeNode<T> node)
        {

            /*
              Left - Current - Right
             */
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Value + " ");
                InOrderTraversal(node.Right);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();

            binaryTree.Insert(5);
            binaryTree.Insert(3);
            binaryTree.Insert(8);
            binaryTree.Insert(1);
            binaryTree.Insert(4);
            binaryTree.Insert(6);
            binaryTree.Insert(9);

            binaryTree.PrintTree();
            Console.WriteLine("Pre Order Traversal");
            binaryTree.PreOrderTraversal();
            Console.WriteLine("Post Order Traversal");
            binaryTree.PostOrderTraversal();
            Console.WriteLine("In Order Traversal");
            binaryTree.InOrderTraversal();
            Console.ReadKey();
        }
        

    }
}
