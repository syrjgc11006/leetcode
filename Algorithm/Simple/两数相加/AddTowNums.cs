using System;
using System.Collections.Generic;
using System.Text;

namespace Simple.两数相加
{
    public class ListNode
    {
        public int val { get; set; }

        public ListNode next { get; set; }

        public ListNode(int x)
        {
            this.val = x;
        }
    }
    public class AddTowNums
    {
        /// <summary>
        /// 时间复杂度：o(max(x,y)) 计算的时间取决于l1和l2的长度
        /// 空间复杂度为：o(max(x,y))
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode target = new ListNode(0);              //哑节点
            ListNode p = l1, q = l2, current = target;
            int carry = 0;                                  //进位
            while (p != null || q != null)
            {
                int x = p != null ? p.val : 0;
                int y = q != null ? q.val : 0;
                int sum = x + y + carry;
                carry = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;                    //将当前节点移到下一个节点
                if (p != null) p = p.next;                                //将p移到下一个几点
                if (q != null) q = q.next;                                //将q移到下一个节点
            }

            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }
            return target.next;
        }

        public static LinkedListNode<int> AddTwoNumbers(LinkedListNode<int> l1, LinkedListNode<int> l2)
        {
            LinkedList<int> target = new LinkedList<int>();              //哑节点
            var current = new LinkedListNode<int>(0);
            target.AddFirst(current);
            LinkedListNode<int> p = l1, q = l2;
            int carry = 0;                                  //进位
            while (p != null || q != null)
            {
                int x = p != null ? p.Value : 0;
                int y = q != null ? q.Value : 0;
                int sum = x + y + carry;
                carry = sum / 10;

                target.AddAfter(current, sum % 10);
                //current.Next = new LinkedListNode<int>(sum % 10);
                current = current.Next;                                   //将当前节点移到下一个节点
                if (p != null) p = p.Next;                                //将p移到下一个几点
                if (q != null) q = q.Next;                                //将q移到下一个节点
            }

            if (carry > 0)
            {
                target.AddLast(carry);
            }
            return target.First.Next;
        }

        /// <summary>
        /// 双向链表存储，可以反序列输出
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static LinkedListNode<int> AddTwoNumbers_Pre(LinkedListNode<int> l1, LinkedListNode<int> l2)
        {
            LinkedList<int> target = new LinkedList<int>();              //哑节点
            var current = new LinkedListNode<int>(0);
            target.AddFirst(current);
            LinkedListNode<int> p = l1, q = l2;
            int carry = 0;                                  //进位
            while (p != null || q != null)
            {
                int x = p != null ? p.Value : 0;
                int y = q != null ? q.Value : 0;
                int sum = x + y + carry;
                carry = sum / 10;

                target.AddAfter(current, sum % 10);
                //target.AddBefore(current.Next, sum % 10);
                //current.Next = new LinkedListNode<int>(sum % 10);
                current = current.Next;                                   //将当前节点移到下一个节点
                
                if (p != null) p = p.Next;                                //将p移到下一个几点
                if (q != null) q = q.Next;                                //将q移到下一个节点
            }

            if (carry > 0)
            {
                target.AddLast(carry);
            }
            return target.Last;
        }
    }
}
