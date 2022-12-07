using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebalance.Changes.Cooking
{
    public class CookingPatches
    {
        [HarmonyPatch(typeof(MicrobeMusherConfig), nameof(MicrobeMusherConfig.CreateBuildingDef))]
        public class MicrobeMusherConfig_CreateBuildingDef_Patch
        {

            public static void Postfix(BuildingDef __result)
            {
                __result.EnergyConsumptionWhenActive = Config.Instance.MicrobeMusherPower;
            }
        }

        [HarmonyPatch(typeof(CookingStationConfig), nameof(CookingStationConfig.CreateBuildingDef))]
        public class ElectricGrillConfig_CreateBuildingDef_Patch
        {
            public static void Postfix(BuildingDef __result)
            {
                __result.EnergyConsumptionWhenActive = Config.Instance.ElectricGrillPower;
            }
        }
    }
}
