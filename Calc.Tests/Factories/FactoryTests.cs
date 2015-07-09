using System;
using Calc.factories;
using Calc.operations.unary;
using NUnit.Framework;

namespace Calc.Tests.Factories
{
    public class FactoryTests
    {
        [TestCase(typeof (Abs), "Abs")]
        [TestCase(typeof (Sin), "Sin")]
        [TestCase(typeof (Ln), "Ln")]
        [TestCase(typeof (Cos), "Cos")]
        [TestCase(typeof (aSin), "Asin")]
        [TestCase(typeof (aCos), "Acos")]
        [TestCase(typeof (Tan), "Tan")]
        [TestCase(typeof (Ctg), "Ctg")]
        [TestCase(typeof (Atan), "Atan")]
        [TestCase(typeof (Actg), "Actg")]
        public void FactoryTest(Type type, string name)
        {
            Type resultType = Factory.CreateCalculator(name).GetType();
            Assert.AreEqual(type, resultType);
        }
    }
}
