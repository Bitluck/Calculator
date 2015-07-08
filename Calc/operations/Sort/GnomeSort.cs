﻿using System;
using System.Collections.Generic;

namespace Calc.Operations.Sort
{
    public class GnomeSort : ISortOperation
    {
        public void Calculate(List<Int32> list)
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
        }
    }
}