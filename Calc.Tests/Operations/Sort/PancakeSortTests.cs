using System;
using System.Collections.Generic;
using Calc.Operations.Sort;
using NUnit.Framework;

namespace Calc.Tests.Operations.Sort
{
    class PancakeSortTests
    {
        //[TestCase(List<Int32>(3, 1, 2), List<Int32>(1, 2, 3))]
        public void PancakeSortTest(List<Int32> argument, List<Int32> result)
        {
            var calculator = new PancakeSort();
            calculator.Calculate(argument);
            Assert.AreEqual(argument, result);
        }
    }
}
