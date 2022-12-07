using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebalance.Changes.Filters
{
    public class FilterPatches
    {
        [HarmonyPatch(typeof(GasFilterConfig), nameof(GasFilterConfig.CreateBuildingDef))]
        class GasFilter_CreateBuildingDef_Patch
        {
            public static void Postfix(BuildingDef __result)
            {
                __result.EnergyConsumptionWhenActive = Config.Instance.FilterPower;
            }
        }

        [HarmonyPatch(typeof(LiquidFilterConfig), nameof(LiquidFilterConfig.CreateBuildingDef))]
        class LiquidFilter_CreateBuildingDef_Patch
        {
            public static void Postfix(BuildingDef __result)
            {
                __result.EnergyConsumptionWhenActive = Config.Instance.FilterPower;
            }
        }

        [HarmonyPatch(typeof(SolidFilterConfig), nameof(SolidFilterConfig.CreateBuildingDef))]
        class SolidFilter_CreateBuildingDef_Patch
        {
            public static void Postfix(BuildingDef __result)
            {
                __result.EnergyConsumptionWhenActive = Config.Instance.FilterPower;
            }
        }
    }
}
