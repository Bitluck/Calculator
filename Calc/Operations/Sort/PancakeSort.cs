using System;
using System.Collections.Generic;

namespace Calc.Operations.Sort
{
    public class PancakeSort : ISortOperation
    {
        /// <summary>
        /// Function of Pancake sort
        /// </summary>
        /// <param name="list">
        /// Unsorted list
        /// </param>
        /// <returns>
        /// Sorted list
        /// </returns>
        public List<int> Calculate(List<int> list)
        {
            if (list.Count < 2)
            {
                return list;
            }
            int i, a, max_num_pos;
            for (i = list.Count; i > 1; i--)
            {
                max_num_pos = 0;
                for (a = 0; a < i; a++)
                {
                    if (list[a].CompareTo(list[max_num_pos]) > 0)
                    {
                        max_num_pos = a;
                    }
                }
                if (max_num_pos == i - 1)
                {
                    continue;
                }
                if (max_num_pos > 0)
                {
                    Flip(list, list.Count, max_num_pos + 1);
                }
                Flip(list, list.Count, i);
            }
            List<int> result = list;
            return result;
        }

        /// <summary>
        /// Function of sorting - The insert
        /// </summary>
        /// <param name="list">
        /// Some list
        /// </param>
        /// <param name="length">
        /// Length of list
        /// </param>
        /// <param name="num">
        /// Iterator
        /// </param>
        private static void Flip(List<Int32> list, int length, int num)
        {
            for (int i = 0; i < --num; i++)
            {
                Int32 swap = list[i];
                list[i] = list[num];
                list[num] = swap;
            }
        }
    }
}
