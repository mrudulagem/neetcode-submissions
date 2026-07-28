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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head = null, curr = null;
        while(list1 != null && list2 != null) {
            ListNode temp;
            if(list1.val <= list2.val) {
                temp = list1;
                list1 = list1.next;
            } else {
                temp = list2;
                list2 = list2.next;
            }
            if(head == null) {
                curr = temp;
                head = curr;
            } else {
                curr.next = temp;
                curr = temp;
            }
        }

        if(list1 != null) {
            if(head == null) {
                head = list1;
            } else {
                curr.next = list1;
            }
        }

        if(list2 != null) {
            if(head == null) {
                head = list2;
            } else {
                curr.next = list2;
            }
        }
        return head;
    }
}