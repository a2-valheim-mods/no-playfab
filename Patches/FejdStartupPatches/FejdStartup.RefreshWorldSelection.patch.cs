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
                __instance.m_crossplayServerToggle.isOn = false;
                __instance.m_crossplayServerToggle.enabled = false;
                UnityEngine.Object.DestroyImmediate(__instance.m_crossplayServerToggle.gameObject);
            }
        }
    }
}