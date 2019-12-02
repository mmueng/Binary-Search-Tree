using System;

namespace Binary_Search_Tree {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Binary Search Tree\n");
            BinaryTree binaryTree = new BinaryTree ();
            binaryTree.Insert (75);
            binaryTree.Insert (76);
            binaryTree.Insert (74);
            binaryTree.Insert (70);
            binaryTree.Find (70);
            binaryTree.Find (79);
            binaryTree.FindRecursive (74);
            binaryTree.FindRecursive (79);

        }
    }
}