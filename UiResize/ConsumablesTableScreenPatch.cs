using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace UiResize
{
    public class ConsumablesTableScreenPatch
    {
        [HarmonyPatch(typeof(ConsumablesTableScreen))]
        [HarmonyPatch("OnActivate")]
        public static class ConsumablesTableScreenOnActivate
        {
            public static void Postfix(ConsumablesTableScreen __instance)
            {
                var config = PeterHan.PLib.Options.POptions.ReadSettings<Config>();

                var transform = __instance.FindComponent<RectTransform>();

                transform.sizeDelta = new Vector2(transform.rect.width, transform.rect.height + config.HeightAdjustment);

                var scroll = __instance.GetComponentInChildren<KScrollRect>();
                var layout = scroll.GetComponentInParent<LayoutElement>();
                layout.preferredHeight += config.HeightAdjustment;
            }
        }
    }
}
