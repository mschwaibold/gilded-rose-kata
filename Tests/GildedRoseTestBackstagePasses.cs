using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class GildedRoseTestBackstagePasses
    {
        [Test]
        public void BackstagePassesUpdateTes_QualityBeforeSellDatet()
        {
            var items = new List<Item> { new Item { Name = Name.Backstage, SellIn = 11, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(6, items[0].Quality);
        }

        [Test]
        public void BackstagePassesUpdateTest_PositiveSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Backstage, SellIn = 10, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(9, items[0].SellIn);
        }

        [Test]
        public void BackstagePassesUpdateTest_NegativeSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Backstage, SellIn = -1, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(-2, items[0].SellIn);
        }

        [Test]
        public void BackstagePassesUpdateTest_10DaysOrLess()
        {
            var items = new List<Item> { new Item { Name = Name.Backstage, SellIn = 10, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(7, items[0].Quality);
        }

        [Test]
        public void BackstagePassesUpdateTest_5DaysOrLess()
        {
            var items = new List<Item> { new Item { Name = Name.Backstage, SellIn = 5, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(8, items[0].Quality);
        }

        [Test]
        public void BackstagePassesUpdateTest_QualityNeverAbove50()
        {
            var items = new List<Item> { new Item { Name = Name.Backstage, SellIn = 10, Quality = 50 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(50, items[0].Quality);
        }

        [Test]
        public void BackstagePassesUpdateTest_QualityAfterSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Backstage, SellIn = 0, Quality = 50 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(0, items[0].Quality);
        }
    }
}
