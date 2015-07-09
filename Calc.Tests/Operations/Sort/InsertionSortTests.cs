using Calc.Operations.Sort;
using NUnit.Framework;

namespace Calc.Tests.Operations.Sort
{
    class InsertionSortTests : SortTests
    {
        [SetUp]
        public void InsertionSetUp()
        {
            Sorter = new InsertionSort();
        }
    }
}
