using System;
using Calc.operations.unary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Unary
{
    class TanTests
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI / 4.0, 1.0)]
        public void TanTest(double argument, double result)
        {
            var calculator = new Tan();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult, 0.1);
        }
    }
}
