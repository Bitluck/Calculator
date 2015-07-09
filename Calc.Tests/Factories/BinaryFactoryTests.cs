using System;
using Calc.factories;
using Calc.operations.binary;
using NUnit.Framework;

namespace Calc.Tests.Factories
{
    public class BinaryFactoryTests
    {
        [TestCase(typeof (Sum), "Sum")]
        [TestCase(typeof (Difference), "Difference")]
        [TestCase(typeof (Divide), "Divide")]
        [TestCase(typeof (Multiply), "Multiply")]
        [TestCase(typeof(Mod), "Mod")]
        [TestCase(typeof(Log), "Log")]
        [TestCase(typeof(Max), "Max")]
        [TestCase(typeof(Min), "Min")]
        [TestCase(typeof(DecimalDivide), "DecimalDivide")]
        [TestCase(typeof(Pow), "Pow")]
        public void BinaryFactoryTest(Type type, string name)
        {
            Type resultType = BinaryFactory.CreateBinaryCalculator(name).GetType();
            Assert.AreEqual(type, resultType);
        }
    }
}
