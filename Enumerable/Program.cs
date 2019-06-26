using System;
using System.Collections.Generic;


namespace Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] arr = { 10, 20, 1000, 40 };
            var list = new List<int> { 10, 20, 1000, 40 };
            var root = new ListNode<int>(10) { 20, 1000, 40 };

            int sum1 = MicMath.Sum(arr);
            int sum2 = MicMath.Sum(list);
            int sum3 = MicMath.Sum(root);
        }
    }
}
