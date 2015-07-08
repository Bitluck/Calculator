using System;
using Calc.operations.unary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Unary
{
    class CosTests
    {
        [TestCase(0, 1)]
        [TestCase(Math.PI / 2.0, 0)]
        public void CosTest(double argument, double result)
        {
            var calculator = new Cos();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult, 0.1);
        }
    }
}
