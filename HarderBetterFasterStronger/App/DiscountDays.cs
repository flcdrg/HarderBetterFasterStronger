using System;
using System.Collections.Generic;

namespace Tests.App
{
    public class DiscountDays
    {
        public IEnumerable<DateTime> GetDays()
        {
            yield return DateTime.Parse("01-01-2020");
            yield return DateTime.Parse("01-04-2020");
            yield return DateTime.Parse("26-12-2020");
        }
    }
}