using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode Head { get; set; }
        int length = 0;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
        }

        /** Get the val of the index-th node in the linked list. If the index
         * is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0 || index > length || Head == null) return -1;

            ListNode current = Head;
            var i = 0;

            while (current != null)
            {
                if (i == index) return current.val;
                current = current.next;
                i++;
            }
            return -1;
        }

        /** Add a node of value val before the first element of the linked list. 
         * After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            ListNode newNode = new ListNode(val);
            newNode.next = Head;
            Head = newNode;
            length++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (Head == null) AddAtHead(val);
            else
            {
                ListNode current = Head;

                while (current.next != null) current = current.next;
                current.next = new ListNode(val);
                length++;
            }
        }

        /** Add a node of val val before the index-th node in the linked list. 
         * If index equals to the length of linked list, the node will be appended
         * to the end of linked list. If index is greater than the length, the node
         * will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index > length || index < 0) return;
            else if (index == 0) AddAtHead(val);
            else if (index == length) AddAtTail(val);
            else
            {
                ListNode newNode = new ListNode(val);
                ListNode previous = Head;

                for (int i = 0; i < index - 1; i++) previous = previous.next;

                newNode.next = previous.next;
                previous.next = newNode;
                length++;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= length || Head == null) return;
            else if (index == 0)
            {
                Head = Head.next;
                length--;
            }
            else
            {
                ListNode current = Head;

                for (int i = 0; i < index; i++)
                {
                    if (i == index - 1) current.next = current.next.next;
                    else current = current.next;
                }
                length--;
            }
        }
    }
}
