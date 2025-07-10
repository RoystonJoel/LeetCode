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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
		ListNode head = null;
        ListNode current = null;
		int carry = 0;
		while(l1 != null || l2 != null || carry != 0)
		{
            if(l1==null)
            {
                ListNode tempNode = new ListNode(0);
                l1 = tempNode;
            }
            if(l2==null)
            {
                ListNode tempNode = new ListNode(0);
                l2 = tempNode;
            }
            int t = l1.val + l2.val;
			if(carry != 0)
			{
				t = t + carry;
				carry = 0;
			}
			if(t > 9){
				carry = t / 10;
				t = t % 10;
			}
            ListNode newNode = new ListNode(t);
            if (head == null){
                head = newNode;
                current = newNode;
            }
            else{
                current.next = newNode;
                current = newNode;
            }
			l1 = l1.next;
			l2 = l2.next;
		}
        return head;
    }
}