using System;
using Calc.operations.binary;
using NUnit.Framework;


namespace Calc.Tests.Operations.Binary
{
    class DifferenceTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(5, -10, 15)]
        [TestCase(0, -2, 2)]
        public void DifferenceTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Difference();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }
    }
}
