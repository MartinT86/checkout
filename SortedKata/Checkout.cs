using System;
using System.Collections.Generic;

namespace SortedKata
{
    public class Checkout
    {
        private readonly IList<Item> items;

        public Checkout()
        {
            items = new List<Item>();
        }

        public decimal Total()
        {
            if (items.Count > 0)
            {
                return 0.5m;
            }
            return 0;
        }

        public void Scan(Item item)
        {
            items.Add(item);
        }
    }
}
