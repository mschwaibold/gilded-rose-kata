//////////////////////////////////////////////////////////////////////////////
//  
//      Author: Max Schwaibold
//      Date: 17.09.2020
//
//////////////////////////////////////////////////////////////////////////////

namespace csharp.UpdateItemStrategies
{
    public class UpdateBackstagePassesStrategy : BaseUpdateItemStrategy
    {
        protected override void AdjustQuality(ItemProxy item)
        {
            item.IncreaseQuality();

            if (item.SellIn < 11)
            {
                item.IncreaseQuality();
            }

            if (item.SellIn < 6)
            {
                item.IncreaseQuality();
            }
        }

        protected override void AdjustQualityAfterSellInDate(ItemProxy item)
        {
            item.ResetQuality();
        }
    }
}
