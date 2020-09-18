//////////////////////////////////////////////////////////////////////////////
//  
//      Author: Max Schwaibold
//      Date: 17.09.2020
//
//////////////////////////////////////////////////////////////////////////////

using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class GildedRoseTestSulfuras
    {
        [Test]
        public void SulfurasUpdateTest()
        {
            var items = new List<Item> { new Item { Name = Name.Sulfuras, SellIn = 0, Quality = 80 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(80, items[0].Quality);
        }

        [Test]
        public void SulfurasUpdateTest_PositiveSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Sulfuras, SellIn = 10, Quality = 80 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(10, items[0].SellIn);
        }

        [Test]
        public void SulfurasUpdateTest_NegativeSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Sulfuras, SellIn = -10, Quality = 80 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(-10, items[0].SellIn);
        }

        [Test]
        public void SulfurasUpdateTest_QualityAfterSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Sulfuras, SellIn = -1, Quality = 80 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(80, items[0].Quality);
        }
    }
}
