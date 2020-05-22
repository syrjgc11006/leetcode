using Simple.两数之和;
using Simple.两数相加;
using System;
using System.Collections.Generic;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwoNumSum.OutPutTowSumArrayIndex_Violence(new int[] { 3, 2, 4 }, 6);

            //ListNode l1 = new ListNode(2);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);

            //ListNode l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            //AddTowNums.AddTwoNumbers(l1,l2);

            //LinkedList<int> a = new LinkedList<int>(); LinkedList<int> b = new LinkedList<int>();
            //LinkedListNode<int> l1 = new LinkedListNode<int>(2);
            //LinkedListNode<int> l1_1 = new LinkedListNode<int>(4);
            //LinkedListNode<int> l1_2 = new LinkedListNode<int>(3);
            //a.AddFirst(l1);
            //a.AddAfter(l1, l1_1);
            //a.AddAfter(l1_1, l1_2);


            //LinkedListNode<int> l2 = new LinkedListNode<int>(5);
            //LinkedListNode<int> l2_1 = new LinkedListNode<int>(6);
            //LinkedListNode<int> l2_2 = new LinkedListNode<int>(4);
            //b.AddFirst(l2);
            //b.AddAfter(l2, l2_1);
            //b.AddAfter(l2_1, l2_2);

            //AddTowNums.AddTwoNumbers(l1, l2);


            LinkedList<int> a = new LinkedList<int>(); LinkedList<int> b = new LinkedList<int>();
            LinkedListNode<int> l1 = new LinkedListNode<int>(2);
            LinkedListNode<int> l1_1 = new LinkedListNode<int>(4);
            LinkedListNode<int> l1_2 = new LinkedListNode<int>(3);
            a.AddFirst(l1);
            a.AddAfter(l1, l1_1);
            a.AddAfter(l1_1, l1_2);


            LinkedListNode<int> l2 = new LinkedListNode<int>(5);
            LinkedListNode<int> l2_1 = new LinkedListNode<int>(6);
            LinkedListNode<int> l2_2 = new LinkedListNode<int>(4);
            b.AddFirst(l2);
            b.AddAfter(l2, l2_1);
            b.AddAfter(l2_1, l2_2);

            AddTowNums.AddTwoNumbers_Pre(l1, l2);

            Console.WriteLine("Hello World!");
        }
    }
}
