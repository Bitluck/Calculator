using System.Collections.Generic;

namespace Calc.Operations.Sort
{
    public class CombSort : ISortOperation
    {
        /// <summary>
        /// Function of Comb sort
        /// </summary>
        /// <param name="list">
        /// Unsorted list
        /// </param>
        /// <returns>
        /// Sorted list
        /// </returns>
        public List<int> Calculate(List<int> list)
        {
            double gap = list.Count;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < list.Count)
                {
                    int igap = i + (int)gap;
                    if (list[i] > list[igap])
                    {
                        int swap = list[i];
                        list[i] = list[igap];
                        list[igap] = swap;
                        swaps = true;
                    }
                    i++;
                }
            }
            List<int> result = list;
            return result;
        }
    }
}
