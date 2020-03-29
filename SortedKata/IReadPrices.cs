using System;
using System.Collections.Generic;
using System.Text;

namespace SortedKata
{
    public interface IReadPrices
    {
        decimal GetPriceFor(Item item);
    }
}
