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

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            Head = new ListNode();
        }

        /** Get the val of the index-th node in the linked list. If the index
         * is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0) return -1; // Can't have a negative index
            else if(index == 0) // Index is Head
            {
                return Head.val;
            }
            else // Index is at least 1
            {
                ListNode current = Head; // Current node is Head at the start
                for (int i = 1; i <= index; i++) current = current.next; // Keep moving to the next node until current node is at given index
                return current.val; // Return current node value
            }
        }

        /** Add a node of value val before the first element of the linked list. 
         * After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            ListNode newNode = new ListNode(); // Create a new node
            newNode.val = val; // Assign given value to new node

            newNode.next = Head; // New node points to Head node
            Head = newNode; // New node becomes Head node
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            ListNode newNode = new ListNode(); // Create new node
            newNode.val = val; // Assign given value to new node

            ListNode current = Head;// Current node is Head at the start

            while (current.next != null) // Move through nodes until next is null, telling us we're at the tail
                current = current.next;

            current.next = newNode;// Current tail node now points to new node            
        }

        /** Add a node of val val before the index-th node in the linked list. 
         * If index equals to the length of linked list, the node will be appended
         * to the end of linked list. If index is greater than the length, the node
         * will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            ListNode newNode = new ListNode(); // Create new node
            newNode.val = val; // Assigns given value to new node
            if(index == 0)
            {
                AddAtHead(val);
            }
            ListNode current = Head; // Start at Head
            ListNode previous = Head; // Tracks node before new node so it can point to new node - starts as Head

            for (int i = 0; i < index; i++)
            { // Move through nodes until current is just before the index
                if (i == (index - 1)) previous = current;
                if (current.next != null) current = current.next; // Make sure we don't try to move past tail
            }

            previous.next = newNode; // Node before index points to new node
            newNode.next = current.next; // New node points to next node
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            ListNode current = Head; // Start at Head node
            ListNode previous = Head; // Tracks node before new node so it can point to next node after deletion - starts as Head

            if (index == 0)
            {
                if (Head.next == null) Head = null;
                else Head = Head.next;
            }
            else
            {
                for (int i = 1; i < index; i++)
                { // Move through nodes until current is just before the index
                    if (i == (index - 1)) previous = current;
                    if (current.next != null) current = current.next; // Make sure we don't try to move past tail
                }

                previous.next = current.next; // Sets previous node's next to deleted node's next
            }
            


        }
    }
}
