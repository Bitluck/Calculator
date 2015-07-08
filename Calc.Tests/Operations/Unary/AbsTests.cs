using System;
using Calc.operations.unary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Unary
{
    class AbsTests
    {
        [TestCase(13, 13)]
        [TestCase(-42, 42)]
        [TestCase(0, 0)]
        public void AbsTest(double argument, double result)
        {
            var calculator = new Abs();
            var testResult = calculator.Calculate(argument);
            Assert.AreEqual(result, testResult);
        }
    }
}
