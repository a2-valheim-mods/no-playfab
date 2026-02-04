using HarmonyLib;
using UnityEngine;
using static A2.NoPlayFab.Consts.Harmony;

namespace A2.NoPlayFab.Patches.FejdStartupPatches
{
    public static class FejdStartupRefreshWorldSelectionPatch
    {
        [HarmonyPatch(typeof(FejdStartup), nameof(FejdStartup.RefreshWorldSelection))]
        [HarmonyPriority(HARMONY_PATCH_PRIORITY_FIRST)]
        public static class Patch
        {
            public static bool Prefix()
            {
                if (PlayerPrefs.GetInt("crossplay", 0) != 0)
                {
                    PlayerPrefs.SetInt("crossplay", 0);
                }
                return HARMONY_PREFIX_RESULT_CONTINUE;
            }

            public static void Postfix(FejdStartup __instance)
            {
                var toggle = __instance.m_crossplayServerToggle;
                toggle.isOn = false;
                toggle.enabled = false;
            }
        }
    }
}