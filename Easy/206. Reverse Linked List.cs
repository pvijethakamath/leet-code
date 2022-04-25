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
    public ListNode ReverseList(ListNode head) {
        if(head == null|| head.next==null)
            return head ;
        ListNode cur=head,prev=null,next=null;
        while(cur!=null)
        {
            next=cur.next;
            cur.next=prev;
            prev=cur;
            cur=next;
        }
        head=prev;
        return head;
    }
}