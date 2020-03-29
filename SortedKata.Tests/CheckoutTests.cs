using NUnit.Framework;
using SortedKata;
using System;

namespace SortedKata.Tests
{
    [TestFixture]
    public class CheckoutTests
    {
        [Test]
        public void GivenNoScannedItems_TotalReturnsZero()
        {
            const decimal expectedTotal = 0;
            var priceReader = new MemoryPriceReader();
            var promotionCalculator = new PromotionCalculator();
            var checkout = new Checkout(priceReader, promotionCalculator);

            var total = checkout.Total();

            Assert.AreEqual(expectedTotal, total);
        }

        [Test]
        public void ScanOneProduct_TotalReturnsPrice()
        {
            const decimal expectedTotal = 0.5m;
            var priceReader = new MemoryPriceReader();
            var promotionCalculator = new PromotionCalculator();
            var checkout = new Checkout(priceReader, promotionCalculator);
            var item = new Item("A99");

            checkout.Scan(item);
            var total = checkout.Total();

            Assert.AreEqual(expectedTotal, total);
        }

        [Test]
        public void ScanTwoProducts_TotalReturnsPriceOfBoth()
        {
            const decimal expectedTotal = 0.8m;
            var priceReader = new MemoryPriceReader();
            var promotionCalculator = new PromotionCalculator();
            var checkout = new Checkout(priceReader, promotionCalculator);
            var itemA = new Item("A99");
            var itemB = new Item("B15");

            checkout.Scan(itemA);
            checkout.Scan(itemB);
            var total = checkout.Total();

            Assert.AreEqual(expectedTotal, total);
        }
    }
}
