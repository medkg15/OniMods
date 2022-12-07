using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Rebalance.Changes.PowerGenerators
{
    public class WoodBurnerPatches
    {
        [HarmonyPatch(typeof(WoodGasGeneratorConfig), nameof(WoodGasGeneratorConfig.CreateBuildingDef))]
        public class WoodGasGeneratorConfig_CreateBuildingDef_Patch
        {
            public static void Postfix(BuildingDef __result)
            {
                __result.SelfHeatKilowattsWhenActive = Config.Instance.WoodBurnerHeat - 1f;
                __result.GeneratorWattageRating = Config.Instance.WoodBurnerPower;
            }
        }

        [HarmonyPatch(typeof(WoodGasGeneratorConfig), nameof(WoodGasGeneratorConfig.DoPostConfigureComplete))]
        public class WoodGasGeneratorConfig_DoPostConfigureComplete_Patch
        {
            public static void Postfix(GameObject go)
            {
                var energyGenerator = go.GetComponent<EnergyGenerator>();
                // reduce wood consumption rate and CO2 production rate
                energyGenerator.formula = EnergyGenerator.CreateSimpleFormula(WoodLogConfig.TAG, Config.Instance.WoodBurnerConsumptionRate, 720f, SimHashes.CarbonDioxide, Config.Instance.WoodBurnerCO2Rate, false, new CellOffset(0, 1), 383.15f);
            }
        }
    }
}
