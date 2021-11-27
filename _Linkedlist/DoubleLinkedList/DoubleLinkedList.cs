using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Linkedlist.DoubleLinkedList
{
    public class DoubleLinkedList<T>
    {
        public DNode<T> head;
        public void InsertFront(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            newNode.next = head;
            newNode.prev = null;
            if (head != null)
            {
                head.prev = newNode;
            }
            head = newNode;
        }
        public void InsertLast(T data)
        {
            DNode<T> newNode = new DNode<T>(data);
            if (head == null)
            {
                newNode.prev = null;
                head = newNode;
                return;
            }
            DNode<T> lastNode = GetLastNode();
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }
        public DNode<T> GetLastNode()
        {
            DNode<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void InsertAfter(DNode<T> prev_node, T data)
        {
            if (prev_node == null)
            {
                throw new NullReferenceException("The given previous node Cannot be null");
            }
            DNode<T> newNode = new DNode<T>(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
            newNode.prev = prev_node;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }
        public void DeleteNodebyKey(T key)
        {
            DNode<T> temp = head;
            DNode<T> prev = null;
            if (temp != null && temp.data.Equals(key))
            {
                head = temp.next;
                return;
            }
            while (temp != null && !temp.data.Equals(key))
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }
        public void ReverseLinkedList()
        {
            DNode<T> prev = null;
            DNode<T> current = head;
            DNode<T> temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                if (current.prev != null)
                {
                    prev.prev = current;
                }
                prev = current;
                current = temp;
            }
            head = prev;
            prev.prev = null;
        }
    }
}
