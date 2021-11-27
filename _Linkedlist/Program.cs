using _Linkedlist.DoubleLinkedList;
using _Linkedlist.SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<string> singleLinkedList = new SingleLinkedList<string>();
            singleLinkedList.InsertLast("aaaa");
            singleLinkedList.InsertLast("bbbb");
            singleLinkedList.InsertLast("cccc");
            singleLinkedList.InsertLast("dddd");
            singleLinkedList.InsertAfter(singleLinkedList.head.next, "-------------");
            singleLinkedList.ReverseLinkedList();
            singleLinkedList.DeleteNodebyKey("cccc");
            DoubleLinkedList<string> doubleLinkedList = new DoubleLinkedList<string>();
            doubleLinkedList.InsertLast("aaaa");
            doubleLinkedList.InsertLast("bbbb");
            doubleLinkedList.InsertLast("cccc");
            doubleLinkedList.InsertLast("dddd");
            doubleLinkedList.InsertLast("eeee");
            doubleLinkedList.InsertAfter(doubleLinkedList.head.next, "-----------------");
            doubleLinkedList.ReverseLinkedList();
            doubleLinkedList.DeleteNodebyKey("-----------------");
        }
    }
}
