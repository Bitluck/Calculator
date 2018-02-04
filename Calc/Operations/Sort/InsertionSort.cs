using System.Collections.Generic;

namespace Calc.Operations.Sort
{
    public class InsertionSort : ISortOperation
    {
        /// <summary>
        /// Function of Insertion sort
        /// </summary>
        /// <param name="list">
        /// Unsorted list
        /// </param>
        /// <returns>
        /// Sorted list
        /// </returns>
        public List<int> Calculate(List<int> list)
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
            List<int> result = list;
            return result;
        }
    }
}
