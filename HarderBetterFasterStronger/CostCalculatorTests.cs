using NUnit.Framework;

using Tests.App;

namespace Tests
{
    public class CostCalculatorTests
    {
        [Test]
        [TestCase(100, 90)]
        public void StandardDiscount_Returns(decimal originalAmount, decimal finalAmount)
        {
            var sut = new CostCalculator();

            var result = sut.ApplyDiscount(originalAmount);

            Assert.AreEqual(finalAmount, result);
        }
    }
}