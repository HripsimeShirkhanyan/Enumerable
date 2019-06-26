using System;

namespace Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(10);
            node.Add(20);
            node.Add(1000);
            node.Add(30);
            node.Add(40);

            int max = node.value;
            var next = node.next;

            //ListNode node = new ListNode(10);
            //node
            //    .Add(20)
            //    .Add(30)
            //    .Add(40);

            //ListNode node = new ListNode()
            //{
            //    value = 10,
            //    next = new ListNode
            //    {
            //        value = 20,
            //        next = new ListNode
            //        {
            //            value = 30,
            //            next = new ListNode
            //            {
            //                value = 40,
            //            }
            //        }
            //    }
            //};

            //ListNode node1 = new ListNode() { value = 10 };
            //ListNode node2 = new ListNode() { value = 20 };
            //node1.next = node2;
            //ListNode node3 = new ListNode() { value = 30};
            //node2.next = node3;
        }
    }
}
