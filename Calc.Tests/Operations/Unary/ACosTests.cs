using System;
using Calc.operations.unary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Unary
{
    class ACosTests
    {
        [TestCase(0, Math.PI / 2.0)]
        [TestCase(1, 0)]
        public void ACosTest(double argument, double result)
        {
            var calculator = new aCos();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
