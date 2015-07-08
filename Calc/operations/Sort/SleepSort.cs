using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Calc.Operations.Sort
{
    public class SleepSort : ISortOperation
    {
        public void Calculate(List<Int32> list)
        {
            List<Int32> resultList = new List<int>();
            foreach (var item in list)
            {
                new Thread(ThreadStart).Start(item);
            }
        }

        private void ThreadStart(object item)
        {
            Thread.Sleep(1000 * (int)item);
            Console.WriteLine(item);
        }
    }
}
