//////////////////////////////////////////////////////////////////////////////
//  
//      Author: Max Schwaibold
//      Date: 17.09.2020
//
//////////////////////////////////////////////////////////////////////////////

namespace csharp
{
    public class ItemProxy
    {
        private readonly Item _item;

        public string Name => _item.Name;
        public int SellIn => _item.SellIn;
        public int Quality => _item.Quality;

        public ItemProxy(Item item)
        {
            _item = item;
        }

        public void IncreaseQuality()
        {
            if (_item.Quality < 50)
            {
                _item.Quality++;
            }
        }

        public void DecreaseQuality()
        {
            if (_item.Quality > 0)
            {
                _item.Quality--;
            }
        }

        public void ResetQuality()
        {
            _item.Quality = 0;
        }

        public void DecreaseSellIn()
        {
            _item.SellIn--;
        }
    }
}
