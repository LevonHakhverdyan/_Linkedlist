﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Linkedlist.SingleLinkedList
{
    public class SingleLinkedList<T>
    {
        public Node<T> head;
        public void InsertFront(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            new_node.next = head;
            head = new_node;
        }
        public void InsertLast(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            if (head == null)
            {
                head = new_node;
                return;
            }
            Node<T> lastNode = GetLastNode();
            lastNode.next = new_node;
        }
        private Node<T> GetLastNode()
        {
            Node<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void InsertAfter(Node<T> prev_node, T new_data)
        {
            if (prev_node == null)
            {
                throw new NullReferenceException("The given previous node Cannot be null");
            }
            Node<T> new_node = new Node<T>(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }
        public void DeleteNodebyKey(T key)
        {
            Node<T> temp = head;
            Node<T> prev = null;
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
            Node<T> prev = null;
            Node<T> current = head;
            Node<T> temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }
        public Node<T> GetNode(T key)
        {
            Node<T> temp = head;
            Node<T> prev = null;
            if (temp != null && temp.data.Equals(key))
            {
                return temp;
            }
            while (temp != null && !temp.data.Equals(key))
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                throw new Exception();
            }
            return temp;
        }
    }


}
