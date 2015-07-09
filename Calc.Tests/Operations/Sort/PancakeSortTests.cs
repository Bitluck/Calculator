﻿using Calc.Operations.Sort;
using NUnit.Framework;

namespace Calc.Tests.Operations.Sort
{
    class PancakeSortTests : SortTests
    {
        [SetUp]
        public void PancakeSetUp()
        {
            Sorter = new PancakeSort();
        }
    }
}
