using Database;
using HarmonyLib;
using PeterHan.PLib.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Rebalance.Changes.Rooms
{
    [HarmonyPatch(typeof(AttributeConverters), nameof(AttributeConverters.Create))]
    public class AttributeConvertersPatches
    {
        public static void Prefix(string id, ref float multiplier, ref float base_value)
        {
            if (id == "MovementSpeed")
            {
                multiplier = Config.Instance.MovementSpeedFactor;
                base_value = Config.Instance.MovementSpeedBase;
            }
        }
    }
}
