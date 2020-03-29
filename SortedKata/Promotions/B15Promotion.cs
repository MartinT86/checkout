using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortedKata.Promotions
{
    public class B15Promotion : IPromotion
    {
        public decimal GetValue(IList<Item> items)
        {
            var a99DiscountCount = items.Count(x => x.Name == "B15") / 2;
            return a99DiscountCount * 0.15m;
        }
    }
}
