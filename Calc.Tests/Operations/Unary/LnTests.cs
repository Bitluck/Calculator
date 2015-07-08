using System;
using Calc.operations.unary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Unary
{
    class LnTests
    {
        [TestCase(1, 0)]
        [TestCase(Math.E, 1)]
        public void LnTest(double argument, double result)
        {
            var calculator = new Ln();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
