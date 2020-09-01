using NUnit.Framework;
using System;
using Tests.App;

namespace Tests
{
    public class RefundPeriodTests
    {
        [Test]
        public void RegularPurchase_Gets7Days()
        {
            var sut = new RefundPeriod();

            var purchasedDate = new DateTime(2020, 01, 01);

            var result = sut.LastDay(purchasedDate);

            Assert.AreEqual(new DateTime(2020, 01, 08), result);
        }
    }
}