using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortedKata.Promotions
{
    public class A99Promotion : IPromotion
    {
        public decimal GetValue(IList<Item> items)
        {
            var a99DiscountCount = items.Count(x => x.Name == "A99") / 3;
            return a99DiscountCount * 0.2m;
        }
    }
}
