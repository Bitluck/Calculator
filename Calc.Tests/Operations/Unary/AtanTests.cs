using System;
using Calc.operations.unary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Unary
{
    class AtanTests
    {
        [TestCase(0, 0)]
        [TestCase(1, Math.PI / 4.0)]
        public void AtanTest(double argument, double result)
        {
            var calculator = new Atan();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
