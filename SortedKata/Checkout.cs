using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedKata
{
    public class Checkout
    {
        private readonly IList<Item> items;
        private readonly IReadPrices PriceReader;
        private readonly ICalculatePromotions PromotionCalculator;

        public Checkout(IReadPrices priceReader, ICalculatePromotions promotionCalculator)
        {
            items = new List<Item>();
            PriceReader = priceReader;
            PromotionCalculator = promotionCalculator;
        }

        public decimal Total()
        {
            var subtotal = 0m;
            foreach (var item in items)
            {
                subtotal += PriceReader.GetPriceFor(item);
            }
            var discounts = PromotionCalculator.Calculate(items);
            return subtotal - discounts;
        }

        public void Scan(Item item)
        {
            items.Add(item);
        }
    }
}
