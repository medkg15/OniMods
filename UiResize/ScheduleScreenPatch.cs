using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ResizeDuplicantManagementScreens
{
    public class ScheduleScreenPatch
    {
        [HarmonyPatch(typeof(ScheduleScreen))]
        [HarmonyPatch("OnSpawn")]
        public static class ScheduleScreenOnSpawn
        {
            public static void Postfix(ScheduleScreen __instance)
            {
                var config = PeterHan.PLib.Options.POptions.ReadSettings<Config>() ?? new Config();

                var transform = __instance.FindComponent<RectTransform>();
                transform.sizeDelta = new Vector2(transform.rect.width, transform.rect.height + config.HeightAdjustment);

                var scroll = __instance.GetComponentInChildren<KScrollRect>();
                var layout = scroll.GetComponentInParent<LayoutElement>();
                layout.preferredHeight += config.HeightAdjustment;
            }
        }
    }
}
