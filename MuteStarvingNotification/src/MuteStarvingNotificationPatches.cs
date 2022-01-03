using Database;
using HarmonyLib;
using Klei.AI;
using STRINGS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MuteStarvingNotificationPatches
{
    [HarmonyPatch(typeof(NotificationScreen))]
    [HarmonyPatch("PlayDingSound")]
    public static class MuteStarvingNotificationPatches
    {
        public static void Prefix(
          ref NotificationScreen __instance,
          Notification notification)
        {
            if (notification.titleText == "Starvation")
            {
                notification.playSound = false;
            }
        }
    }
}
