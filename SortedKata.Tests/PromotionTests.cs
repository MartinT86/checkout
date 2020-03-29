using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortedKata.Tests
{
    [TestFixture]
    public class PromotionTests
    {
        [Test]
        public void ThreeA99_Returns130()
        {
            const decimal expectedTotal = 1.30m;
            var priceReader = new MemoryPriceReader();
            var checkout = new Checkout(priceReader);
            var item = new Item("A99");

            checkout.Scan(item);
            checkout.Scan(item);
            checkout.Scan(item);
            var total = checkout.Total();

            Assert.AreEqual(expectedTotal, total);
        }
    }
}
