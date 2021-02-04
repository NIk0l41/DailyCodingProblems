using System;

namespace DCP_008
{
    class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node("0",
                        new Node("1"),
                        new Node("0",
                            new Node("1", new Node("1"),
                                new Node("1")),
                            new Node("0")
                        )
                        ) ;
            Node b = new Node(
                "a",
                new Node(
                        "a"
                    ),
                new Node(
                        "a",
                        new Node(
                                "a"
                            ),
                        new Node(
                                "a",
                                null,
                                new Node("A")
                            )
                    )
                );
            Node c = new Node(
                "a",
                new Node(
                        "c"
                    ),
                new Node(
                        "b",
                        new Node(
                                "b"
                            ),
                        new Node(
                                "b",
                                null,
                                new Node(
                                        "b"
                                    )
                            )
                    )
                );
            Console.WriteLine(univalCount(c));
            Console.ReadLine();
        }

        /// <summary>
        /// Initiates the counting process
        /// </summary>
        /// <param name="root">The root node.</param>
        /// <returns></returns>
        static int univalCount(Node root) {
            int left_count = count(root.left, root.val);
            int right_count = count(root.right, root.val);
            return left_count + right_count;

        }

        /// <summary>
        /// Determines whether a given node is considered 'unival'. If it is, returns a 1, if not, returns a 0.
        /// </summary>
        /// <param name="node">The node to be checked for unival qualities.</param>
        /// <param name="val">The root value for checking.</param>
        /// <returns></returns>
        static int isUnival(Node node, string val) {
            if (node.val != val) {
                return 1;
            }
            if (node.left == null && node.right == null) {
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Returns a count of all unival trees present for half of the tree.
        /// </summary>
        /// <param name="node">The node to be checked.</param>
        /// <param name="val">The root value for checking.</param>
        /// <returns></returns>
        static int count(Node node, string val) {
            int tmp = 0;
            if (node == null) {
                return 0;
            }
            tmp += count(node.left, val) + count(node.right, val) + isUnival(node, val);
            return tmp;
        }
    }

    class Node {

        public string val;
        public Node left;
        public Node right;

        public Node(string val, Node left = null, Node right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }

    }
}
