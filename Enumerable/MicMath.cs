using System.Collections.Generic;

namespace Enumerable
{
    partial class ListNode<T>
    {
        static class MicMath
        {
            public static int Sum(IEnumerable<int> source)
            {
                int sum = 0;
                foreach (int item in source)
                    sum += item;
                return sum;
            }

            public static int Sum(IEnumerable<short> source)
            {
                int sum = 0;
                foreach (int item in source)
                    sum += item;
                return sum;
            }
            //public static int Sum(int[] arr)
            //{
            //    int sum = 0;
            //    foreach (int item in arr)
            //        sum += item;
            //    return sum;
            //}

            //public static int Sum(List<int> list)
            //{
            //    int sum = 0;
            //    foreach (int item in list)
            //        sum += item;
            //    return sum;
            //}

            //public static int Sum(ListNode listNode)
            //{
            //    int sum = 0;
            //    foreach (int item in listNode)
            //        sum += item;
            //    return sum;
            //}
        }
    }
}
