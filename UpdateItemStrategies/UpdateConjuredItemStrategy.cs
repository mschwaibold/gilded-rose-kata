//////////////////////////////////////////////////////////////////////////////
//  
//      Author: Max Schwaibold
//      Date: 17.09.2020
//
//////////////////////////////////////////////////////////////////////////////

namespace csharp.UpdateItemStrategies
{
    public class UpdateConjuredItemStrategy : BaseUpdateItemStrategy
    {
        protected override void AdjustQuality(ItemProxy item)
        {
            item.DecreaseQuality();
            item.DecreaseQuality();
        }

        protected override void AdjustQualityAfterSellInDate(ItemProxy item)
        {
            item.DecreaseQuality();
            item.DecreaseQuality();
        }
    }
}
