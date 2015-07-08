using System;
using Calc.operations.binary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Binary
{
    class DivideTests
    {
        [TestCase(1, 2, 0.5)]
        [TestCase(10, -2, -5)]
        [TestCase(18, 0, double.PositiveInfinity)]
        public void DivideTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Divide();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }
    }
}
