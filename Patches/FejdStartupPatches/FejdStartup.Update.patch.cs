using HarmonyLib;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.FejdStartupPatches
{
    public static class FejdStartupUpdatePatch
    {
        [HarmonyPatch(typeof(FejdStartup), nameof(FejdStartup.Update))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static void Postfix(FejdStartup __instance)
            {
                if (__instance.m_startGamePanel.activeInHierarchy)
                {
                    __instance.SetToggleState(__instance.m_crossplayServerToggle, false);
                }
            }
        }
    }
}