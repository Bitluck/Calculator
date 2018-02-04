using System;
using Calc.Operations.Sort;

namespace Calc.Factories
{
    public static class SortFactory
    {
        public static ISortOperation CreateSortCalculator(string calculator)
        {
            switch (calculator)
            {
                case "PancakeSort":
                    return new PancakeSort();
                case "InsertionSort":
                    return new InsertionSort();
                case "GnomeSort":
                    return new GnomeSort();
                case "CombSort":
                    return new CombSort();
                default:
                    throw new Exception("Unknown Operation.");
            }
        }
    }
}
