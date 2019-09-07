using LinkedListDLLCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinkedListDLLCase.LinkedListHelpers;

namespace LinkedListConsoleTest
{
        public class Node
        {
            public string data;
            public Node next;
            public Node(string n)
            {
                this.data = n;

            }

        }
        public class LinkedList
        {
            public Node head;
            public Node current;
            public int count;

            public LinkedList()
            {
                head = new Node("E");
                current = head;
            }
        }

       


        public class Program
        {
            public static void Main(string[] args)
            {

                LinkedList list = new LinkedList();
                list.head.next = new Node("B");
                list.head.next.next = new Node("E");
                list.head.next.next.next = new Node("E");
                list.head.next.next.next.next = new Node("B");
                list.head.next.next.next.next = new Node("A");
                list.head.next.next.next.next = new Node("B");
                printNodes(list.head);
                removeDuplicates(list.head);
                printNodes(list.head);
            }

            public static void printNodes(Node n)
            {
                while (n != null)
                {
                    Console.WriteLine(n.data);
                    n = n.next;
                }

            }
            public static void removeDuplicates(Node n)
            {
                Node current = n;
                Node runner = current;

                if (n == null)
                    return;

                while (current != null)
                {
                    while (runner.next != null)
                    {
                        if (current.data == runner.data)
                        {
                            current.next = runner.next.next;
                        }
                        runner = runner.next;
                    }
                    current = current.next;
                }
            }
        }
    }

