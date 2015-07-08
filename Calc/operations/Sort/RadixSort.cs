using System;
using System.Collections.Generic;

namespace Calc.Operations.Sort
{
    public class RadixSort : ISortOperation
    {
        public void Calculate(List<Int32> list)
        {
            int i, j;
            List<Int32> tmp = list;
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < list.Count; ++i)
                {
                    bool move = (list[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)  // shift the 0's to old's head
                        list[i - j] = list[i];
                    else                            // move the 1's to tmp
                        tmp[j++] = list[i];
                }


                Copy(tmp, 0, list, list.Count - j, j);
                //Array.Copy(tmp, 0, list, list.Count - j, j);

            }
        }

        private void Copy(List<Int32> tmp, int beginTmp, List<Int32> list, int beginList, int length)
        {
            for (int i = 0; i < length; ++i)
            {
                list[beginList + i] = tmp[beginTmp + i];
            }
        }
    }
}
