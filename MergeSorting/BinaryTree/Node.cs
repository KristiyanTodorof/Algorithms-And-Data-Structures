using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> right { get; set; }
        public Node<T> left { get; set; }

        public Node(T d)
        {
            this.data = d;
            this.left = null;
            this.right = null;
        }
    }
}
