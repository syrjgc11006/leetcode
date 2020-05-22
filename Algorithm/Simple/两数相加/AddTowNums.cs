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
    }
}
