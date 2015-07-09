using System;
using Calc.Factories;
using Calc.Operations.Sort;
using NUnit.Framework;

namespace Calc.Tests.Factories
{
    public class SortFactoryTests
    {
        [TestCase(typeof (InsertionSort), "InsertionSort")]
        [TestCase(typeof (PancakeSort), "PancakeSort")]
        [TestCase(typeof (GnomeSort), "GnomeSort")]
        [TestCase(typeof (CombSort), "CombSort")]
        public void SortFactoryTest(Type type, string name)
        {
            Type resultType = SortFactory.CreateSortCalculator(name).GetType();
            Assert.AreEqual(type, resultType);
        }
    }
}
