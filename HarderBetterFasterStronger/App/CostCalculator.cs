using System;

namespace Tests.App
{
    public class CostCalculator
    {
        public decimal ApplyDiscount(decimal amount)
        {
            decimal multiplier;
            // Boxing day sales
            if (DateTime.Now.Month == 12 && DateTime.Now.Day == 26)
            {
                multiplier = 0.20M;
            }
            else
            {
                multiplier = 0.10M;
            }

            return amount - (amount * multiplier);
        }
    }
}