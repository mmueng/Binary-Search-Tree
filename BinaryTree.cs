using System;
namespace Binary_Search_Tree {
    public class BinaryTree {
        private TreeNode root;
        public TreeNode Root {
            get { return root; }
        }

        public void Insert (int data) {
            // if the root is not null then we call the insert method on the root Node
            if (root != null) {
                root.Insert (data);
            } else {
                // if the root is null then we set the root to be a new based on the data passed in
                root = new TreeNode (data);
                System.Console.WriteLine (root.Data);
            }
        }

        public TreeNode Find (int data) {
            // if the root is not null then we call the find method on the root
            if (root != null) {
                return root.Find (data);
            } else {
                // the root is null so we return null, nothing to find
                return null;
            }
        }
        public TreeNode FindRecursive (int data) {
            if (root != null) {
                return root.FindRecursive (data);
            } else {
                return null;
            }
        }
    }
}