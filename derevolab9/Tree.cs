using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derevolab9
{
    public class Tree
    {
        public Node root;

        public Tree()
        {
            root = null;
        }

        public Node Search(int data)
        {
            Node current = root;
            while (current != null && current.Data != data)
            {
                if (data < current.Data)
                    current = current.Left;
                else
                    current = current.Right;
            }
            return current;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (root == null)
            {
                root = newNode;
                return;
            }
            Node current = root;
            while (true)
            {
                if (data < current.Data)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        return;
                    }
                    current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        return;
                    }
                    current = current.Right;
                }
            }
        }
    }
}
