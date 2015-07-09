using System.Collections.Generic;
using NUnit.Framework;

namespace Calc.Tests.Operations.Sort
{
    [TestFixture]
    public abstract class SortTests
    {
        public ISortOperation Sorter;

        private List<List<int>> unsorted;
        private List<List<int>> sorted;

        [SetUp]
        public void SetUp()
        {
            unsorted = new List<List<int>>
            {
                new List<int> {3, 1, 2},
                new List<int> {3, 5, 2},
                new List<int> {8, -1, 0, 3, 89, -23, 42, 6},
                new List<int> {20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, -1},
                new List<int> {-1, 0, -2, 0, -3, 0, 3, 0, 2, 0, 1}
            };

            sorted = new List<List<int>>
            {
                new List<int> {1, 2, 3},
                new List<int> {2, 3, 5},
                new List<int> {-23, -1, 0, 3, 6, 8, 42, 89},
                new List<int> {-1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                new List<int> {-3, -2, -1, 0, 0, 0, 0, 0, 1, 2, 3}
            };
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void SortTest(int index)
        {
            var result = Sorter.Calculate(unsorted[index]);
            Assert.AreEqual(sorted[index], result);
        }
    }
}
