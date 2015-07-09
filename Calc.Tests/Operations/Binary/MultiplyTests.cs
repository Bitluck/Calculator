using Calc.operations.binary;
using NUnit.Framework;

namespace Calc.Tests.Operations.Binary
{
    class MultiplyTests
    {
        [TestCase(-1, 2, -2)]
        [TestCase(5, -2, -10)]
        [TestCase(0, 29, 0)]
        public void MultiplyTest(double firstArgument, double secondArgument, double result)
        {
            var calculator = new Multiply();
            var testResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, testResult);
        }
    }
}
