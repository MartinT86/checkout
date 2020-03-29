using System;
using System.Collections.Generic;
using System.Text;

namespace SortedKata
{
    public class MemoryPriceReader : IReadPrices
    {
        private readonly Dictionary<string, decimal> prices;

        public MemoryPriceReader()
        {
            prices = new Dictionary<string, decimal>
            {
                {"A99", 0.5m},
                {"B15", 0.3m},
                {"C40", 0.6m}
            };
        }

        public decimal GetPriceFor(Item item)
        {
            return prices[item.Name];
        }
    }
}
