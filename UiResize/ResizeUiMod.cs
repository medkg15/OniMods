using Harmony;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using PeterHan;
using PeterHan.PLib;
using PeterHan.PLib.Options;

namespace UiResize
{
    public class ResizeUiMod
    {
        public const int HeightChange = 0;

        public static class Mod_OnLoad
        {
            public static void OnLoad()
            {
                PUtil.InitLibrary(true);
                POptions.RegisterOptions(typeof(Config));
            }
        }
    }
}
