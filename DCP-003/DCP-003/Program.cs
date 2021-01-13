using System;

namespace DCP_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node("Root", new Node("left", new Node("left.left")), new Node("right"));
            if (deserialise(serialise(node)).left.left.val == "left.left") {
                Console.WriteLine("Yay!");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Returns a string of selected branches.
        /// </summary>
        /// <param name="Root">The Root Node.</param>
        /// <returns></returns>
        static string serialise(Node Root) {
            Node b = Root.left;
            Node c = b.left;
            return c.val;
        }

        static Node deserialise(string Tree) {
            string[] parts = Tree.Split('.');
            Node newTree = new Node("Root");
            switch (parts[0]) {
                case "left":
                    newTree.left = new Node("left");
                    switch (parts[1]) {
                        case "left":
                            newTree.left.left = new Node("left.left");
                            break;
                    }
                    break;
                case "right":
                    newTree.right = new Node("right");
                    break;
            }
            return newTree;
        }
    }

    class Node{

        public string val;
        public Node left;
        public Node right;

        public Node(string val, Node left = null, Node right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public void NewBranch(string side, Node left = null, Node right = null) {
            
        }

    }
}
