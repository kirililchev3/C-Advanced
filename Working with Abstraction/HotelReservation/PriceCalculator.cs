using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class PriceCalculator
    {
        private decimal pricePerNight;
        private int nights;
        private SeasonMultiplier seasonMultiplier;
        private DiscountPrecentage discountPrecentage;

        public PriceCalculator(string[] commandArgs)
        {
            pricePerNight = decimal.Parse(commandArgs[0]);
            nights = int.Parse(commandArgs[1]);
            seasonMultiplier = Enum.Parse<SeasonMultiplier>(commandArgs[2]);
            discountPrecentage = DiscountPrecentage.None;

            if (commandArgs.Length == 4)
            {
                discountPrecentage = Enum.Parse<DiscountPrecentage>(commandArgs[3]);
            }
                 
        }

        public decimal GetTotalPrice()
        {
            decimal basePrice = pricePerNight * nights * (int)seasonMultiplier;
            return basePrice - basePrice * (decimal)discountPrecentage / 100;
        }
    }
}
