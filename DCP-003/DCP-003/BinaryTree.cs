using System;
using System.Collections.Generic;
using System.Text;

namespace NIk0l41
{
    namespace BinaryTreeSorter {

        class Node{
            public string val;
            public Node left;
            public Node right;

            public Node(string val, Node left = null, Node right = null){
                this.val = val;
                this.left = left;
                this.right = right;
            }

            public BinaryTreeMessage AddBranch(Node node, bool onLeftSide = true) {
                BinaryTreeMessage mess = new BinaryTreeMessage(BinaryTreeMessageType.Error, null);
                switch (onLeftSide) {
                    case true:
                        if (node.left != null){
                            node.left = new Node(null);
                            mess.type = BinaryTreeMessageType.Success;
                            mess.message = "Node Successfully added to tree.";
                        }
                        else {
                            mess.type = BinaryTreeMessageType.Error;

                        }
                        break;
                    case false:
                        node.right = new Node(null);
                        break;
                }
            }

        }

        class BinaryTreeMessage {

            public BinaryTreeMessageType type;
            public string message;

            public BinaryTreeMessage(BinaryTreeMessageType type, string message) {
                this.type = type;
                this.message = message;
            }
        }

        enum BinaryTreeMessageType {
            Error,
            Notification,
            Success
        }
    }
}
