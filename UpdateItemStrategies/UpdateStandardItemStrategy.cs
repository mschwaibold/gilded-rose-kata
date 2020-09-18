//////////////////////////////////////////////////////////////////////////////
//  
//      Author: Max Schwaibold
//      Date: 17.09.2020
//
//////////////////////////////////////////////////////////////////////////////

namespace csharp.UpdateItemStrategies
{
    public class UpdateStandardItemStrategy : BaseUpdateItemStrategy
    {
        protected override void AdjustQuality(ItemProxy item)
        {
            item.DecreaseQuality();
        }

        protected override void AdjustQualityAfterSellInDate(ItemProxy item)
        {
            item.DecreaseQuality();
        }
    }
}
