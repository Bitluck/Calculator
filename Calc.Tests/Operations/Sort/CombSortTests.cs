using Calc.Operations.Sort;
using NUnit.Framework;

namespace Calc.Tests.Operations.Sort
{
    class CombSortTests : SortTests
    {
        [SetUp]
        public void CombSetUp()
        {
            Sorter = new CombSort();
        }
    }
}
