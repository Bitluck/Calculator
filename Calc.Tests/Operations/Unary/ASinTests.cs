using System;
using Calc.operations.unary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Unary
{
    class ASinTests
    {
        [TestCase(0, 0)]
        [TestCase(1, Math.PI / 2.0)]
        public void ASinTest(double argument, double result)
        {
            var calculator = new aSin();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
