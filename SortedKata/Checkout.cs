using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedKata
{
    public class Checkout
    {
        private readonly IList<Item> items;
        private readonly IReadPrices PriceReader;

        public Checkout(IReadPrices priceReader)
        {
            items = new List<Item>();
            PriceReader = priceReader;
        }

        public decimal Total()
        {
            var subtotal = 0m;
            foreach (var item in items)
            {
                subtotal += PriceReader.GetPriceFor(item);
            }
            var discounts = 0m;
            var a99DiscountCount = items.Count(x => x.Name == "A99") / 3;
            discounts = a99DiscountCount * 0.2m;

            return subtotal - discounts;
        }

        public void Scan(Item item)
        {
            items.Add(item);
        }
    }
}
