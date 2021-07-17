using HarmonyLib;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using PeterHan.PLib.Options;
using PeterHan.PLib.Core;

namespace ResizeDuplicantManagementScreens
{
    public class ResizeUiMod : KMod.UserMod2
    {
        public const int HeightChange = 0;

        public override void OnLoad(Harmony harmony)
        {
            harmony.PatchAll();
            PUtil.InitLibrary(true);
            new POptions().RegisterOptions(this, typeof(Config));
        }
    }
}
