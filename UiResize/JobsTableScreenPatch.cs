using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace UiResize
{
    public class JobsTableScreenPatch
    {
        [HarmonyPatch(typeof(JobsTableScreen))]
        [HarmonyPatch("OnActivate")]
        public static class JobsTableScreenOnActivate
        {
            public static void Postfix(JobsTableScreen __instance)
            {
                var config = PeterHan.PLib.Options.POptions.ReadSettings<Config>();

                var transform = __instance.FindComponent<RectTransform>();
                transform.sizeDelta = new Vector2(transform.rect.width, transform.rect.height + config.HeightAdjustment);

                var scroll = __instance.GetComponentInChildren<KScrollRect>();
                var layout = scroll.GetComponentInParent<LayoutElement>();
                layout.preferredHeight += config.HeightAdjustment;

                var options = __instance.GetComponentsInChildren<LayoutElement>()
                    .First(e => e.name == "OptionsButton");

                options.GetComponent<RectTransform>().localPosition = new Vector3(-15, -50, 0);
            }
        }
    }
}
