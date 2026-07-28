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
    public void ReorderList(ListNode head) {
        // 2 -> 4 -> 6 -> 8
        //      s         f
        // 2 -> 4 -> 6 -> 8 -> 10
        //           s             f
        // 1
        // s  f
        ListNode slow = head, fast = head.next;
        while(fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next?.next;
        }

        // second = s.next and reverse that list
        ListNode second = slow.next, prev = slow.next = null;
        while(second != null) {
            var next = second.next;
            second.next = prev;
            prev = second;
            second = next;
        }

        // 2 -> 4 -> 6 -> 8
        // 1st            2nd
        // 2 -> 4 -> 6 -> 8 -> 10
        // 1st                 2nd
        // 1
        // 1st 2nd

        ListNode first = head;
        second = prev;
        while(second != null) {
            var temp1 = first.next;
            var temp2 = second.next;
            first.next = second;
            second.next = temp1;
            first = temp1;
            second = temp2;
        }
    }
}
