using Calc.Operations.Sort;
using NUnit.Framework;

namespace Calc.Tests.Operations.Sort
{
    class GnomeSortTests : SortTests
    {
        [SetUp]
        public void GnomeSetUp()
        {
            Sorter = new GnomeSort();
        }
    }
}
