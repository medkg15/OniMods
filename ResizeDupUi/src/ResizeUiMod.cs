using HarmonyLib;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using PeterHan.PLib.Options;
using PeterHan.PLib.Core;

namespace ResizeDupUi
{
    public class ResizeDupsUiMod : KMod.UserMod2
    {
        public const int HeightChange = 0;

        public override void OnLoad(Harmony harmony)
        {
            harmony.PatchAll();
            PUtil.InitLibrary(false);
            var options = new POptions();
            options.RegisterOptions(this, typeof(Config));

        }
    }
}
