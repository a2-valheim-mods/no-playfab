using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.FejdStartupPatches
{
    public static class FejdStartupShowLogInWithPlayFabWindowPatch
    {
        [HarmonyPatch(typeof(FejdStartup), nameof(FejdStartup.ShowLogInWithPlayFabWindow))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix()
            {
                return HARMONY_PREFIX_RESULT_BREAK;
            }
        }
    }
}
