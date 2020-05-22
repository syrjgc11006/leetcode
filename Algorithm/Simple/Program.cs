using Simple.两数之和;
using Simple.两数相加;
using System;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwoNumSum.OutPutTowSumArrayIndex_Violence(new int[] { 3, 2, 4 }, 6);

            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            AddTowNums.AddTwoNumbers(l1,l2);

            Console.WriteLine("Hello World!");
        }
    }
}
