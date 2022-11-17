using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Node
    {
        /*Node class represents the node of doubly linked list.
        * It consoscts of the information part and links to
        * its succeeding and preceeding nodes
        * in terms od next and previous nodes.*/
        public int rollNumber;
        public string name;
        public Node next;/*points to the suceeding node*/
        public Node prev;/*points to the preceeding node*/
    }
    class DoubleLinkedList
    {
        Node START;
        public DoubleLinkedList()
        {
            START = null;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
