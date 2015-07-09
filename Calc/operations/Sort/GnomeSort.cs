using System.Collections.Generic;

namespace Calc.Operations.Sort
{
    public class GnomeSort : ISortOperation
    {
        /// <summary>
        /// Function of Gnome sort
        /// </summary>
        /// <param name="list">
        /// Unsorted list
        /// </param>
        /// <returns>
        /// Sorted list
        /// </returns>
        public List<int> Calculate(List<int> list)
        {
            int i = 1;
            int j = 2;

            while (i < list.Count)
            {
                if (list[i - 1] <= list[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    int tmp = list[i - 1];
                    list[i - 1] = list[i];
                    list[i] = tmp;
                    i -= 1;
                    if (i == 0)
                    {
                        i = 1;
                        j = 2;
                    }
                }
            }
            List<int> result = list;
            return result;
        }
    }
}
