using System;
using Calc.operations.unary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Unary
{
    class SinTests
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI / 2.0, 1)]
        public void SinTest(double argument, double result)
        {
            var calculator = new Sin();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
