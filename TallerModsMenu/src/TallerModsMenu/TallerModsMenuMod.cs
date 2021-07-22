using HarmonyLib;

namespace TallerModsMenu
{
    public class TallerModsMenuMod : KMod.UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            harmony.PatchAll();
        }
    }
}
