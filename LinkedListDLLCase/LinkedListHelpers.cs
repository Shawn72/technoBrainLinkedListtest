using System;

namespace LinkedListDLLCase
{
    public static class LinkedListHelpers
    {
        /// <summary>
        /// LINKED LIST NODE REPRESENTATION
        /// </summary>        
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
        }/// <summary>
        /// PRINT NODES IN OUTPUT
        /// </summary>
        /// <param name="n"></param>

        public static void printNodes(Node n)
        {
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }

        }       

        /// <summary>
        /// REMOVE LINKED DUPLICATES
        /// </summary>
        /// <param name="n"></param>
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
