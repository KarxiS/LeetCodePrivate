using System;
using System.Diagnostics.Metrics;
using System.Reflection;

public class Solution2
{
    public Solution2()
    {
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

        ListNode actualNode = null;
        int zvysok = 0;
        while (l1 is not null || l2 is not null||zvysok>9)
        {
            int number1 = 0;
            int number2 = 0;
            if (l1 is not null)
            {
                number1 = l1.val;
            }

            if (l2 is not null)
            {
                number2 = l2.val;
            }

            int sum = number1 + number2 + zvysok;

            actualNode = new ListNode((sum) % 10, actualNode);
            if (sum > 9)
            {
                zvysok = sum - 9;
                sum = sum % 10;
            }
            else
            {
                zvysok = 0;
            }




            if (l1 is not null)
            {

                if (l1.next is not null)
                {
                    l1 = l1.next;

                }
                else
                {
                    l1 = null;
                }
            }

            if (l2 is not null)
            {
                if (l2.next is not null)
                {
                    l2 = l2.next;
                }
                else
                {
                    l2 = null;
                }
                
            }
        }


        if (zvysok > 0)
        {
            
                actualNode = new ListNode(zvysok, actualNode);
            
            
        }

        actualNode = OtocListNode(actualNode);
        return actualNode;
    }

    public ListNode OtocListNode(ListNode l)
    
    {
        ListNode prev = null;
        ListNode current = l;
        while (current != null)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }

}

