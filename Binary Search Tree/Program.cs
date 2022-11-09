using System;

namespace Binary_Search_Tree
{
    internal class BinarySearchTree
    {
        public class Node
        {
            public int key { get; set; }
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public BinarySearchTree(int value)
        {
            root = new Node(value);
        }

        internal void insert(int key) { root = insertRec(root, key); }

        internal Node insertRec(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.key)
                root.left = insertRec(root.left, key);
            else if (key > root.key)
                root.right = insertRec(root.right, key);
            return root;
        }
        internal void inorder() { inorderRec(root); }
        internal void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.WriteLine(root.key);
                inorderRec(root.right);
            }
        }
    }

    internal  class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.insert(50);
            tree.insert(30);
            tree.insert(20);
            tree.insert(40);
            tree.insert(70);
            tree.insert(60);
            tree.insert(80);

            tree.inorder();

        }
    }

}
