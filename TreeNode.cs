using System;

namespace Binary_Search_Tree {

    public class TreeNode {
        //property to store the nodes data could be a key and object pair
        private int data;
        public int Data {
            get { return data; }
        }
        // Right Child
        private TreeNode rightNode;
        public TreeNode RightNode {
            get { return rightNode; }
            set { rightNode = value; }
        }
        // Left Child
        private TreeNode leftNode;
        public TreeNode LeftNode {
            get { return leftNode; }
            set { leftNode = value; }
        }
        private bool isDeleted; // Delete variable;
        public bool IsDeleted {
            get { return isDeleted; }
        }
        // Node constractor
        public TreeNode (int value) {
            data = value;
        }

        // Method to set delete
        public void Delete () {
            isDeleted = true;
        }

        //recursively calls insert down the tree until it find an open spot
        public void Insert (int value) {
            // if the value passed in is greater or equal to the data then insert to right node
            if (value >= data) {
                // if right child node is null create one
                if (rightNode == null) {
                    rightNode = new TreeNode (value);
                    System.Console.WriteLine (rightNode.Data);
                } else {
                    // if right node is not null recursivly call insert on the right node
                    rightNode.Insert (value);

                }
            } else {
                // if the value passed in is less than the data then insert to left node
                if (leftNode == null) {
                    // if the left node is null then create a new node
                    leftNode = new TreeNode (value);
                    System.Console.WriteLine (leftNode.Data);
                } else {
                    // if the left node is not null then recursively call insert on the left node
                    leftNode.Insert (value);

                }
            }
        }

        public TreeNode Find (int value) {
            // this node is starting current node
            TreeNode currentNode = this;
            // Loop through this node and all of the childern of this node
            while (currentNode != null) {
                // if the current node data is equal to the value passed in return it
                if (value == currentNode.data && isDeleted == false) {
                    System.Console.WriteLine ("Found node: " + currentNode.data);
                    return currentNode;
                } else if (value > currentNode.data) {
                    // if the value passed in is greater than the current data then go to the right child
                    currentNode = currentNode.rightNode;
                } else {
                    currentNode = currentNode.leftNode;
                }
            }
            System.Console.WriteLine ("Not found!");
            return null;
        }

        public TreeNode FindRecursive (int value) {
            // value passed in matches nodes data return the node
            if (value == data && isDeleted == false) {
                System.Console.WriteLine ("Found node: " + this.data);
                return this;
            } else if (value < data && leftNode != null) {
                // if the value passed in is less than  the current data then go to the left child
                return leftNode.FindRecursive (value);
            } else if (rightNode != null) {
                //if its grreater than go to the right child node
                return rightNode.FindRecursive (value);
            } else {
                System.Console.WriteLine ("Not found!");
                return null;
            }
        }
    }

}