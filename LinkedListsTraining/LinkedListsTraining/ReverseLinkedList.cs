using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining.ReverseLinkedList
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            var current = head;
            var temp = new ListNode();

            if (head == null) return head;
            while(current.next != null)
            {
                temp = current.next;
                current.next = temp.next;
                temp.next = head;
                head = temp;
            }
            return head;
        }
    }
}
