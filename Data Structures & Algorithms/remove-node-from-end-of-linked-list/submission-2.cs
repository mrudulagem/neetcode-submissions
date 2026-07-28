/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // dummy to handle when head needs to be removed.
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode left = dummy, right = head;
        // Reach the nth node on the right
        // dummy -> 1 -> 2 -> 3 -> 4, n = 2
        // left             right
        // dummy -> 5 -> null, n = 1
        // left          right
        // dummy -> 1 -> 2-> null, n = 2
        // left              right
        int i = 0;
        while(i < n) {
            right = right.next;
            i++;
        }

        // Move both left and right forward until right is not at the end.
        // dummy -> 1 -> 2 -> 3 -> 4 -> null, n = 2
        //              left            right
        // dummy -> 5 -> null, n = 1
        // left          right
        // dummy -> 1 -> 2-> null, n = 2
        // left              right
        while(right != null) {
            left = left.next;
            right = right.next;
        }

        // The node next to left needs to be removed.
        left.next = left.next?.next;
        
        // dummy.next is the appropriate head to be returned.
        return dummy.next;
    }
}
