using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Node<T>
    {
        T data;
        Node<T> link;

        public Node(T data, Node<T> link)
        {
            this.data = data;
            this.link = link;
        }
    }
}
