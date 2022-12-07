using Database;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Rebalance.Changes.Decor
{
    public class CookingPatches
    {
        [HarmonyPatch(typeof(ArtableStage), MethodType.Constructor, new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(bool), typeof(ArtableStatusItem), typeof(string), typeof(string) })]
        public class ArtableStage_Constructor_Patch
        {
            public static void Prefix(ref int decor_value)
            {
                if (decor_value > 0)
                {
                    decor_value += Config.Instance.ArtDecorBoost;
                }
            }
        }

        [HarmonyPatch(typeof(PixelPackConfig), nameof(PixelPackConfig.CreateBuildingDef))]
        class PixelPackConfig_BuildingDef_Patch
        {
            static void Postfix(BuildingDef __result)
            {
                __result.BaseDecor = Config.Instance.PixelPackDecor;
                __result.BaseDecorRadius = Config.Instance.PixelPackDecorRadius;
            }
        }

        // Jumping Joya
        [HarmonyPatch(typeof(CactusPlantConfig), nameof(CactusPlantConfig.CreatePrefab))]
        class JumpingJoya_CreatePrefab_Patch
        {
            public static void Postfix(GameObject __result)
            {
                ChangeDecorTo(__result, new EffectorValues(Config.Instance.DecorativePlantDecor, Config.Instance.DecorativePlantDecorRadius));
            }
        }

        // Mirth Leaf
        [HarmonyPatch(typeof(LeafyPlantConfig), nameof(LeafyPlantConfig.CreatePrefab))]
        class MirthLeaf_CreatePrefab_Patch
        {
            public static void Postfix(GameObject __result)
            {
                ChangeDecorTo(__result, new EffectorValues(Config.Instance.DecorativePlantDecor, Config.Instance.DecorativePlantDecorRadius));
            }
        }

        // Bluff Briar
        [HarmonyPatch(typeof(PrickleGrassConfig), nameof(PrickleGrassConfig.CreatePrefab))]
        class BluffBriar_CreatePrefab_Patch
        {
            public static void Postfix(GameObject __result)
            {
                ChangeDecorTo(__result, new EffectorValues(Config.Instance.DecorativePlantDecor, Config.Instance.DecorativePlantDecorRadius));
            }
        }

        // Mellow Mallow
        [HarmonyPatch(typeof(WineCupsConfig), nameof(WineCupsConfig.CreatePrefab))]
        class MellowMallow_CreatePrefab_Patch
        {
            public static void Postfix(GameObject __result)
            {
                ChangeDecorTo(__result, new EffectorValues(Config.Instance.DecorativePlantDecor, Config.Instance.DecorativePlantDecorRadius));
            }
        }

        // Bliss Burst
        [HarmonyPatch(typeof(CylindricaConfig), nameof(CylindricaConfig.CreatePrefab))]
        class BlissBurst_CreatePrefab_Patch
        {
            public static void Postfix(GameObject __result)
            {
                ChangeDecorTo(__result, new EffectorValues(Config.Instance.DecorativePlantDecor, Config.Instance.DecorativePlantDecorRadius));
            }
        }

        private static void ChangeDecorTo(GameObject go, EffectorValues decor)
        {
            var decorPlantComponent = go.GetComponent<PrickleGrass>();
            decorPlantComponent.positive_decor_effect = decor;
            var decorProvider = go.GetComponent<DecorProvider>();
            if (decorProvider != null)
            {
                decorProvider.SetValues(decor);
            }
        }
    }
}
