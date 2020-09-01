using System;
using System.Linq;
using NUnit.Framework;
using Tests.App;

namespace Tests
{
    public class DiscountDaysTests
    {
        [Test]
        public void AprilFoolsDay_IsDiscount()
        {
            var sut = new DiscountDays();

            var result = sut.GetDays().ToList();

            Assert.Contains(new DateTime(2020, 4, 1), result);
        }
    }
}