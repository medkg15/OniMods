using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Rebalance.Changes.Electrolyzer
{
    public class ElectrolyzerPatches
    {
        [HarmonyPatch(typeof(ElectrolyzerConfig), nameof(ElectrolyzerConfig.CreateBuildingDef))]
        public class ElectrolyzerConfig_CreateBuildingDef_Patch
        {
            public static void Postfix(BuildingDef __result)
            {
                __result.EnergyConsumptionWhenActive = Config.Instance.ElectrolyzerPower;
                __result.ExhaustKilowattsWhenActive = Config.Instance.ElectrolyzerHeatProduction - 1f;
            }
        }

        [HarmonyPatch(typeof(ElectrolyzerConfig), nameof(ElectrolyzerConfig.ConfigureBuildingTemplate))]
        public class ElectrolyzerConfig_ConfigureBuildingTemplate_Patch
        {
            public static void Postfix(GameObject go)
            {
                CellOffset cellOffset = new CellOffset(0, 1);
                var ec = go.GetComponent<ElementConverter>();
                ec.consumedElements = new ElementConverter.ConsumedElement[1]
                {
                    new ElementConverter.ConsumedElement(new Tag("Water"), Config.Instance.ElectrolyzerWaterConsumption)
                };
                ec.outputElements = new ElementConverter.OutputElement[2]
                {
                    new ElementConverter.OutputElement(Config.Instance.ElectrolyzerWaterConsumption, SimHashes.Oxygen, 343.15f, outputElementOffsetx: ((float) cellOffset.x), outputElementOffsety: ((float) cellOffset.y)),
                    new ElementConverter.OutputElement(Config.Instance.ElectrolyzerHydrogenProduction, SimHashes.Hydrogen, 343.15f, outputElementOffsetx: ((float) cellOffset.x), outputElementOffsety: ((float) cellOffset.y))
                };
            }
        }
    }
}
