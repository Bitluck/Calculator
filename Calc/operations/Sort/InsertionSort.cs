using System;
using System.Collections.Generic;

namespace Calc.Operations.Sort
{
    public class InsertionSort : ISortOperation
    {
        public void Calculate(List<Int32> list)
        {
            var first = 0;
            var last = list.Count - 1;
            for (var i = first + 1; i <= last; i++)
            {
                var entry = list[i];
                var j = i;

                while (j > first && list[j - 1].CompareTo(entry) > 0)
                    list[j] = list[--j];

                list[j] = entry;
            }
        }
    }
}
