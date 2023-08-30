using LeetCode;
using System.Numerics;

Solution2 solution = new Solution2();

ListNode node1 = new ListNode(9);
ListNode node2 = new ListNode(9, node1);
ListNode node3 = new ListNode(9, node2);

ListNode node6 = new ListNode(9);
ListNode node7 = new ListNode(9,node6);
ListNode node8 = new ListNode(9,node7);

solution.AddTwoNumbers(node3, node8);

Solution2 solution1 = new Solution2();

ListNode node12 = new ListNode(0);


ListNode node62 = new ListNode(0);


var result =solution1.AddTwoNumbers(node8, node3);
while (result != null)
{
    System.Console.WriteLine(result.val);
    result = result.next;
}




