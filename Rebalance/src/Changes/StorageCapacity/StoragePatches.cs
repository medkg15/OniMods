using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Rebalance.Changes.StorageCapacity
{
    [HarmonyPatch(typeof(GasReservoirConfig), nameof(GasReservoirConfig.ConfigureBuildingTemplate))]
    public class GasReservoir_ConfigureBuildingTemplate_Patch
    {
        public static void Postfix(GameObject go)
        {
            var storage = go.GetComponent<Storage>();
            storage.capacityKg = Config.Instance.GasReservoirCapacity;
            var conduitConsumer = go.GetComponent<ConduitConsumer>();
            conduitConsumer.capacityKG = storage.capacityKg;
        }
    }

    [HarmonyPatch(typeof(LiquidReservoirConfig), nameof(LiquidReservoirConfig.ConfigureBuildingTemplate))]
    public class LiquidReservoir_ConfigureBuildingTemplate_Patch
    {
        public static void Postfix(GameObject go)
        {
            var storage = go.GetComponent<Storage>();
            storage.capacityKg = Config.Instance.LiquidReservoirCapacity;
            var conduitConsumer = go.GetComponent<ConduitConsumer>();
            conduitConsumer.capacityKG = storage.capacityKg;
        }
    }
}
