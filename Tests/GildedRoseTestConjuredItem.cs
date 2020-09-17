using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class GildedRoseTestConjuredItem
    {
        [Test]
        public void ConjuredItemUpdateTest_QualityBeforeSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Conjured, SellIn = 10, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(3, items[0].Quality);
        }

        [Test]
        public void ConjuredItemUpdateTest_PositiveSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Conjured, SellIn = 10, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(9, items[0].SellIn);
        }

        [Test]
        public void ConjuredItemUpdateTest_NegativeSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Conjured, SellIn = -1, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(-2, items[0].SellIn);
        }

        [Test]
        public void ConjuredItemUpdateTest_QualityNotNegative()
        {
            var items = new List<Item> { new Item { Name = Name.Conjured, SellIn = 8, Quality = 0 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(0, items[0].Quality);
        }

        [Test]
        public void ConjuredItemUpdateTest_QualityAfterSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Conjured, SellIn = 0, Quality = 4 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(-1, items[0].SellIn);
            Assert.AreEqual(0, items[0].Quality);
        }
    }
}
