using HarmonyLib;
using Klei.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebalance.Changes.Incubator
{
    public class IncubatorPatches
    {
        [HarmonyPatch(typeof(IncubationMonitor.Instance), "UpdateIncubationState")]
        public class IncubationMonitor_UpdateIncubationState_Patch
        {
            public static void Postfix(IncubationMonitor.Instance __instance)
            {
                if (Config.Instance.LullabyPowerRequired)
                {
                    var effects = __instance.GetComponent<Effects>();

                    if (effects.HasEffect("EggSong") && (!__instance.sm.incubatorIsActive.Get(__instance) || !__instance.sm.inIncubator.Get(__instance)))
                    {
                        effects.Remove("EggSong");
                    }
                }
            }
        }

        [HarmonyPatch(typeof(EggIncubatorConfig), nameof(EggIncubatorConfig.CreateBuildingDef))]
        public class Incubator_BuildingDef_Patch
        {
            public static void Postfix(BuildingDef __result)
            {
                __result.EnergyConsumptionWhenActive = Config.Instance.IncubatorPower;
            }
        }
    }
}
