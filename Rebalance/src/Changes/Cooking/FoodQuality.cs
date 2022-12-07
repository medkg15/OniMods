using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebalance.Changes.Cooking
{
    public static class FoodQuality
    {
        public static void TweakFoodQuality()
        {
            TUNING.FOOD.FOOD_TYPES.COOKED_MEAT.Quality = Config.Instance.FoodQualityBbq; // from 3
        }

    }
}
