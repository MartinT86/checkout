using System;
using System.Collections.Generic;
using System.Text;

namespace SortedKata
{
    public interface ICalculatePromotions
    {
        decimal Calculate(IList<Item> items);
    }
}
