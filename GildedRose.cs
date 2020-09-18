using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly UpdateItemStrategyLocator _updateItemStrategyLocator;

        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
            _updateItemStrategyLocator = new UpdateItemStrategyLocator();
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                UpdateQuality(new ItemProxy(Items[i]));
            }
        }

        public void UpdateQuality(ItemProxy item)
        {
            var updateStrategy = _updateItemStrategyLocator.GetStrategy(item);

            updateStrategy.ApplyTo(item);            
        }
    }
}
