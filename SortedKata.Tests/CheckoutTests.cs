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
            var checkout = new Checkout();

            var total = checkout.Total();

            Assert.AreEqual(expectedTotal, total);
        }

        [Test]
        public void ScanOneProduct_TotalReturnsPrice()
        {
            const decimal expectedTotal = 0.5m;
            var checkout = new Checkout();
            var item = new Item("A99");

            checkout.Scan(item);
            var total = checkout.Total();

            Assert.AreEqual(expectedTotal, total);
        }
    }
}
