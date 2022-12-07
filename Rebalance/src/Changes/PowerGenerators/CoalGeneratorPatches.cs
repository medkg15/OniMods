using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Rebalance.Changes.PowerGenerators
{
    public class CoalGeneratorPatches
    {
        [HarmonyPatch(typeof(GeneratorConfig), nameof(GeneratorConfig.ConfigureBuildingTemplate))]
        public class GeneratorConfig_ConfigureBuildingTemplate_Patch
        {
            public static void Postfix(GameObject go)
            {
                var energyGenerator = go.GetComponent<EnergyGenerator>();
                energyGenerator.formula = EnergyGenerator.CreateSimpleFormula(SimHashes.Carbon.CreateTag(), 1f, 600f, SimHashes.CarbonDioxide, Config.Instance.CoalGeneratorCO2Rate, false, new CellOffset(1, 2), 383.15f);
            }
        }
    }
}
