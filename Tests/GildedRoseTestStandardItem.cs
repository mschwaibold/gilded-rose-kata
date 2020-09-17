using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class GildedRoseTestStandardItem
    {
        [Test]
        public void StandardItemUpdateTest_QualityBeforeSellDate()
        {
            var items = new List<Item> { new Item { Name = "Item", SellIn = 10, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(4, items[0].Quality);
        }

        [Test]
        public void StandardItemUpdateTest_PositiveSellDate()
        {
            var items = new List<Item> { new Item { Name = "Item", SellIn = 10, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(9, items[0].SellIn);
        }

        [Test]
        public void StandardItemUpdateTest_NegativeSellDate()
        {
            var items = new List<Item> { new Item { Name = "Item", SellIn = -1, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(-2, items[0].SellIn);
        }

        [Test]
        public void StandardItemUpdateTest_QualityNotNegative()
        {
            var items = new List<Item> { new Item { Name = "Item", SellIn = 8, Quality = 0 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(0, items[0].Quality);
        }

        [Test]
        public void StandardItemUpdateTest_QualityAfterSellDate()
        {
            var items = new List<Item> { new Item { Name = "Item", SellIn = 0, Quality = 4 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(2, items[0].Quality);
        }
    }
}
