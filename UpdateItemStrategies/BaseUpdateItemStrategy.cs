//////////////////////////////////////////////////////////////////////////////
//  
//      Author: Max Schwaibold
//      Date: 17.09.2020
//
//////////////////////////////////////////////////////////////////////////////

namespace csharp.UpdateItemStrategies
{
    public abstract class BaseUpdateItemStrategy : IUpdateItemStrategy
    {
        public void ApplyTo(ItemProxy item)
        {
            AdjustQuality(item);
            AdjustSellIn(item);

            if (item.SellIn < 0)
            {
                AdjustQualityAfterSellInDate(item);
            }
        }

        protected abstract void AdjustQuality(ItemProxy item);

        protected virtual void AdjustSellIn(ItemProxy item)
        {
            item.DecreaseSellIn();
        }

        protected abstract void AdjustQualityAfterSellInDate(ItemProxy item);
    }
}
