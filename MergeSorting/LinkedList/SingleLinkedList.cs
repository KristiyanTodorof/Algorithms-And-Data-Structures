using AngleSharp.Dom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinkedList
{
    public class SingleLinkedList<T> : IEnumerable
    {
        Node<T> head;

        public void InsertFront(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            new_node.next = this.head;
            this.head = new_node;
        }

        public void InsertLast(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);

            if (this.head == null)
            {
                this.head = new_node;
                return;
            }

            Node<T> last = this.head;
            while (last.next != null)
            {
                last = last.next;
            }

            last.next = new_node; new_node = this.head;
            new_node.next = this.head;
        }
        public void InsertAfter(Node<T> prev_node, T new_data )
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be null!");
                return;
            }

            Node<T> new_node = new Node<T>(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }
        public Node<T> GetNodeByKey(T key)
        {
            Node<T> current = this.head;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.data, key))
                {
                    return current;
                }

                current = current.next;
            }

            return null;
        }
        public bool DeleteNodeByKey(T key) 
        {
            if (this.head == null)
            {
                return false;
            }

            if (EqualityComparer<T>.Default.Equals(head.data, key))
            {
                head = head.next;
                return true;
            }

            Node<T> current = this.head;
            Node<T> previous = null;

            while (current != null && !EqualityComparer<T>.Default.Equals(current.data, key))
            {
                previous = current;
                current = current.next;
            }

            if (current == null)
            {
                return false;
            }

            previous.next = current.next;
            return true;
        }
        public void ReversedLinkedList()
        {
            Node<T> previous = null, current = this.head, next = null;

            while (current != null)
            {
                next = current.next;
                current.next = previous;

                previous = current;
                current = next;
            }
            this.head = previous;
        }
        public IEnumerator GetEnumerator()
        {
            var node = head;
            while (node != null) 
            {
                yield return node;
                node = node.next;
            }
        }
    }
}
