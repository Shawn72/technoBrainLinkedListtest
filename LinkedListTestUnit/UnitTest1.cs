using static LinkedListDLLCase.LinkedListHelpers;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// RUN THE TEST TO ADD AND REMOVE ITEMS FROM LIST
        /// </summary>
        [Test]
        public static void TestLinkedListHelpersLibrary()
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
       
    }
}
