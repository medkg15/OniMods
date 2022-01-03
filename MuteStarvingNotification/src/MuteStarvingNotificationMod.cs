using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuteStarvingNotificationPatches
{

    public class MuteStarvingNotificationMod : KMod.UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            harmony.PatchAll();
        }
    }
}
