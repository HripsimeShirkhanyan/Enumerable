using System;
using System.Collections.Generic;
using System.Text;

namespace LessonEnumerable
{
    class Math
    {
        public static int Sum(IEnumerable<int> source)
        {
            int sum = 0;
            foreach (int item in source)
                sum += item;
            return sum;
        }
    }
}
