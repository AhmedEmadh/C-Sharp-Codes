using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralTreeExample
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }
        public TreeNode(T value)
        {
            this.Value = value;
            this.Children = new List<TreeNode<T>>();
        }
        public void AddChild(TreeNode<T> child)
        {
            this.Children.Add(child);
        }
        public void RemoveChild(TreeNode<T> child)
        {
            this.Children.Remove(child);
        }
        public TreeNode<T> Find(T value)
        {
            
            if (EqualityComparer<T>.Default.Equals(Value,value))
            {
                return this;
            }
            foreach (var child in this.Children)
            {
                var result = child.Find(value);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }
    }
    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }
        public Tree(T value)
        {
            this.Root = new TreeNode<T>(value);
        }
        public TreeNode<T> Find(T value)
        {
            return this.Root?.Find(value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the tree from the sample
            Tree<string> tree = new Tree<string>("CEO");
            TreeNode<string> cfo = new TreeNode<string>("CFO");
            TreeNode<string> cto = new TreeNode<string>("CTO");
            TreeNode<string> cmo = new TreeNode<string>("CMO");
            // Add the children to the root
            tree.Root.AddChild(cfo);
            tree.Root.AddChild(cto);
            tree.Root.AddChild(cmo);
            
            TreeNode<string> Accountant = new TreeNode<string>("Accountant");
            TreeNode<string> Developer = new TreeNode<string>("Developer");
            TreeNode<string> UXDesigner = new TreeNode<string>("UX Designer");
            TreeNode<string> SocialMediaManager = new TreeNode<string>("Social Media Manager");
            // Add the children to the CFO
            cfo.AddChild(Accountant);
            // Add the children to the CTO
            cto.AddChild(Developer);
            cto.AddChild(UXDesigner);
            // Add the children to the CMO
            cmo.AddChild(SocialMediaManager);

            // Print the tree
            PrintTree(tree.Root, 0);

            // Find a node
            var node = tree.Find("Developer");
            Console.WriteLine();
            Console.WriteLine(node.Value);
        }
        public static void PrintTree(TreeNode<string> node, int level)
        {
            Console.WriteLine(new string(' ', level * 2) + node.Value);
            foreach (var child in node.Children)
            {
                PrintTree(child, level + 1);
            }
        }
    }
}
