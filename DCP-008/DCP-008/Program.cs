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

        static int univalCount(Node root) {
            int left_count = count(root.left, root.val);
            int right_count = count(root.right, root.val);
            return left_count + right_count;

        }

        static bool isUnival(Node node, string val) {
            if (node.val != val) {
                return true;
            }
            if (node.left == null && node.right == null) {
                return true;
            }
            return false;
        }

        static int count(Node node, string val) {
            int tmp = 0;
            if (node == null) {
                return 0;
            }
            if (isUnival(node, val)) {
                tmp++;
            }
            tmp += count(node.left, val) + count(node.right, val);
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
