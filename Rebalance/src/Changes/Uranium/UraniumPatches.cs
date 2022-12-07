using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Rebalance.Changes.StorageCapacity
{
    public class UraniumPatches
    {
        [HarmonyPatch(typeof(UraniumCentrifugeConfig), nameof(UraniumCentrifugeConfig.ConfigureBuildingTemplate))]
        public class UraniumCentrifugeConfig_ConfigureBuildingTemplate_Patch
        {
            public static void Postfix(GameObject go)
            {
                //ComplexRecipeManager.Get().GetRecipe()
                // change duration to make more centrifuges necessary to run a reactor?
                // but make them more efficient?
            }
        }
    }
}
