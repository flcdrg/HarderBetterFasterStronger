using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.App
{
    public class RefundPeriod
    {
        public DateTime LastDay(DateTime purchaseDate)
        {
            if (purchaseDate.Month == 12)
            {
                // Extended refund period after Christmas
                return purchaseDate.AddDays(14);
            }
            else
            {
                return purchaseDate.AddDays(7);
            }
        }
    }
}
