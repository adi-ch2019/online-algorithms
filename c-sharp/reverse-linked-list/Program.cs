
using System;
using System.Collections.Generic;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode? prev = null;
        ListNode? current = head;
        
        while (current != null)
        {
            ListNode nextTemp = current.next;
            current.next = prev;
            prev = current;
            current = nextTemp;
        }
        
        return prev;
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        // Test for reversing a linked list
        Console.WriteLine("Reversing a Linked List:");
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        Console.WriteLine("Original Linked List: ");
        PrintLinkedList(head);
        
        Solution solution = new Solution();
        ListNode reversedHead = solution.ReverseList(head);
        
        Console.WriteLine("Reversed Linked List: ");
        PrintLinkedList(reversedHead);
        
       
    }

    public static void PrintLinkedList(ListNode head)
    {
        ListNode? current = head;
        while (current != null)
        {
            Console.Write(current.val + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }
}
