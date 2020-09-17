using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class GildedRoseTestAgedBrie
    {
        [Test]
        public void AgedBrieUpdateTest_QualityBeforeSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Brie, SellIn = 10, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(6, items[0].Quality);
        }

        [Test]
        public void AgedBrieUpdateTest_PositiveSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Brie, SellIn = 10, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(9, items[0].SellIn);
        }

        [Test]
        public void AgedBrieUpdateTest_NegativeSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Brie, SellIn = -1, Quality = 5 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(-2, items[0].SellIn);
        }

        [Test]
        public void AgedBrieUpdateTest_QualityNeverAbove50()
        {
            var items = new List<Item> { new Item { Name = Name.Brie, SellIn = 10, Quality = 50 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(50, items[0].Quality);
        }

        [Test]
        public void AgedBrieUpdateTest_QualityAfterSellDate()
        {
            var items = new List<Item> { new Item { Name = Name.Brie, SellIn = 0, Quality = 4 } };
            var rose = new GildedRose(items);

            rose.UpdateQuality();

            Assert.AreEqual(6, items[0].Quality);
        }
    }
}
