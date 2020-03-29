using System;
using System.Collections.Generic;
using System.Text;

namespace SortedKata
{
    public class PromotionCalculator : ICalculatePromotions
    {
        private readonly IList<IPromotion> Promotions;

        public PromotionCalculator()
        {
            Promotions = new List<IPromotion>();
        }

        public PromotionCalculator(IList<IPromotion> promotions)
        {
            Promotions = promotions;
        }

        public decimal Calculate(IList<Item> items)
        {
            var subtotal = 0m;
            foreach (var promotion in Promotions)
            {
                subtotal += promotion.GetValue(items);
            }
            return subtotal;
        }
    }
}
