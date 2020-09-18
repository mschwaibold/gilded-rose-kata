//////////////////////////////////////////////////////////////////////////////
//  
//      Author: Max Schwaibold
//      Date: 17.09.2020
//
//////////////////////////////////////////////////////////////////////////////

using csharp.UpdateItemStrategies;
using System.Collections.Generic;

namespace csharp
{
    public class UpdateItemStrategyLocator
    {
        private readonly Dictionary<string, IUpdateItemStrategy> _strategies = new Dictionary<string, IUpdateItemStrategy>();
        private readonly IUpdateItemStrategy _standardUpdateItemStrategy = new UpdateStandardItemStrategy();

        public UpdateItemStrategyLocator()
        {
            _strategies.Add(Name.Brie, new UpdateAgedBrieStrategy());
            _strategies.Add(Name.Backstage, new UpdateBackstagePassesStrategy());
            _strategies.Add(Name.Sulfuras, new UpdateSulfurasStrategy());
            _strategies.Add(Name.Conjured, new UpdateConjuredItemStrategy());
        }

        public IUpdateItemStrategy GetStrategy(string name)
        {
            if(_strategies.ContainsKey(name))
            {
                return _strategies[name];
            }

            return _standardUpdateItemStrategy;
        }

        public IUpdateItemStrategy GetStrategy(ItemProxy item)
        {
            return GetStrategy(item.Name);
        }
    }
}
