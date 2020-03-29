using System;
using System.Collections.Generic;

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
            return subtotal;
        }

        public void Scan(Item item)
        {
            items.Add(item);
        }
    }
}
