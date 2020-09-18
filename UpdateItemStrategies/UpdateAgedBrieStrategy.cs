//////////////////////////////////////////////////////////////////////////////
//  
//      Author: Max Schwaibold
//      Date: 17.09.2020
//
//////////////////////////////////////////////////////////////////////////////

namespace csharp.UpdateItemStrategies
{
    public class UpdateAgedBrieStrategy : BaseUpdateItemStrategy
    {
        protected override void AdjustQuality(ItemProxy item)
        {
            item.IncreaseQuality();
        }

        protected override void AdjustQualityAfterSellInDate(ItemProxy item)
        {
            item.IncreaseQuality();
        }
    }
}
