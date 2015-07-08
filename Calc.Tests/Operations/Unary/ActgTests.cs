using System;
using Calc.operations.unary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Unary
{
    class ActgTests
    {
        [TestCase(0, double.PositiveInfinity)]
        [TestCase(Math.PI / 2.0, 1)]
        public void ActgTest(double argument, double result)
        {
            var calculator = new Actg();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult, 0.1);
        }
    }
}
