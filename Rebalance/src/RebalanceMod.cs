using HarmonyLib;
using PeterHan.PLib.Core;
using PeterHan.PLib.Options;
using Rebalance.Changes.Cooking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebalance
{
    public class RebalanceMod : KMod.UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            FoodQuality.TweakFoodQuality();
            harmony.PatchAll();
            PUtil.InitLibrary(false);
            var options = new POptions();
            options.RegisterOptions(this, typeof(Config));
            base.OnLoad(harmony);
        }
    }
}
