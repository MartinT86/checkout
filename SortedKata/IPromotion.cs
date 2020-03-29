using System;
using System.Collections.Generic;
using System.Text;

namespace SortedKata
{
    public interface IPromotion
    {
        decimal GetValue(IList<Item> items);
    }
}
