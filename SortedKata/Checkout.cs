using System;
using System.Collections.Generic;

namespace SortedKata
{
    public class Checkout
    {
        private readonly IList<Item> items;
        private readonly Dictionary<string, decimal> prices;

        public Checkout()
        {
            items = new List<Item>();
            prices = new Dictionary<string, decimal>
            {
                {"A99", 0.5m},
                {"B15", 0.3m},
                {"C40", 0.6m}
            };
        }

        public decimal Total()
        {
            var subtotal = 0m;
            foreach (var item in items)
            {
                var itemPrice = prices[item.Name];
                subtotal += itemPrice;
            }
            return subtotal;
        }

        public void Scan(Item item)
        {
            items.Add(item);
        }
    }
}
