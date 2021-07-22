using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TallerModsMenu
{
    public class ModsScreenPatch
    {
        [HarmonyPatch(typeof(ModsScreen))]
        [HarmonyPatch("OnActivate")]
        public static class ModsScreenOnActivate
        {
            public static void Postfix(ModsScreen __instance)
            {
                var transforms = __instance.GetComponentsInChildren<RectTransform>();

                float? screenHeight = null;

                for (int i = 0; i < transforms.Length; i++)
                {
                    RectTransform transform = transforms[i];

                    // first component is the overall screen - resolution of the game.
                    // use this to get the game's height.
                    if (i == 0)
                    {
                        screenHeight = transform.rect.height;
                    }

                    // third component is the mods panel itself, which we will resize.
                    if (i == 2)
                    {
                        if (!screenHeight.HasValue)
                        {
                            Debug.LogError("ResizeModsScreen: Could not determine screen height.  Will not resize.");
                        }
                        else
                        {
                            // leave a little space at top and bottom.
                            transform.sizeDelta = new Vector2(transform.rect.width, screenHeight.Value - 100);
                        }

                        break;
                    }
                }
            }
        }
    }
}
