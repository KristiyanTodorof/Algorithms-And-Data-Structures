using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeTraversal<T>
    {
        public void Order(Node<T> root)
        {
            if(root == null)
                return;

            Order(root.left);

            Order(root.right);

            Console.Write(root.data + " ");
        }
    }
}
